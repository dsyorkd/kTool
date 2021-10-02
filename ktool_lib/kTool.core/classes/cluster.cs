using System;

namespace kTool.core
{
    public class Cluster
    {

      public int id {get; set; }; 
      public string name = "";
      public string created ="";
      public string status { get; set; }
      public cluster()
      {

      }
      public void GetClusterDetails(int id, string clusterName)
      {
        id = id; 
        name = clusterName;
        Console.WriteLine("Id: , Name: ")
      }
    }
    
}
