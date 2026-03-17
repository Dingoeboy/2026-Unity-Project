using UnityEngine;
using System.IO;
using JetBrains.Annotations;

public class FileManager : MonoBehaviour
{

    public string textFileName; //this will be the filename include extension
    public string[] textFileContents; // this will be the array that holds the file content
    void Start()
    {

        textFileName = "myData";//this will be the filename
        CreateNewTextFile(textFileName); //calling function i wrote myself 

        WriteToFile(textFileName, "My favourite captain is Captain Picard.");
        WriteToFile(textFileName, "My second favorite captain is Captain Kirk.");

    }

    /// <summary>
    /// This function creates a new file at a loction if it dosen't already exist and then has input as file name
    /// </summary>
    /// <param name="fileName"></param>
    public void CreateNewTextFile(string fileName)
    {
        // create a file path string for the full path on that specfic computer
        string directoryPath = Application.dataPath + "/DataFiles/" + fileName + ".txt";

        if (Directory.Exists(directoryPath) == false)
        {
            // file doesnt exist so create it
            Directory.CreateDirectory(Application.dataPath + "/DataFiles");  //create the directory
            File.WriteAllText(directoryPath, fileName + '\n');

        }
        else
        {
            Debug.Log("file already exists. Not creating it");


        }

        
    }// end of create new text file function

    public void WriteToFile(string fileName, string data) 
    {
        string directoryPath = Application.dataPath + "/DataFiles/" + fileName + ".txt";

        File.AppendAllText(directoryPath, data + "\n");


    }


    public string[] ReadTextFileContents(string fileName)
    {
        string directoryPath = Application.dataPath + "/DataFiles/" + fileName + ".txt";
        string[] textContents = new string[0];
        //you have to check if the file exists
        if(File.Exists(directoryPath) == true)
        {
            textContents = File.ReadAllLines(directoryPath);
        }
            return textContents;


    }
    public void CreateCSV(string fileName)
    { // takes a filename
      // check if it exists
      // if not create it

        string directoryPath = Application.dataPath + "/DataFiles/";
        string filePath = directoryPath + fileName + ".csv";

        // check if the folder if not create it
        if (!Directory.Exists(directoryPath))
        {

            Directory.CreateDirectory(directoryPath);
        }

        if (!File.Exists(filePath))
        {

            File.WriteAllText(filePath, "Name,Level \n");
            Debug.Log("CSVe created with headers at: " + filePath);

        }

        else
        {
            Debug.Log("CSV file already exists" + filePath);

        }

    }
}// end of class FileManager
