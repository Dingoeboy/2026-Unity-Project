using UnityEngine;
using System.IO;

public class FileManager : MonoBehaviour
{

    public string textFileName; //this will be the filename include extension
    public string[] textFileContents; // this will be the array that holds the file content
    void Start()
    {

        textFileName = "myData";//this will be the filename
        CreateNewTextFile(textFileName); //calling function i wrote myself 
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


    }








}
