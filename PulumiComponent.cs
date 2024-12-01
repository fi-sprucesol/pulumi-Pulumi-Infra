using Pulumi;
using PulumiGithub.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PulumiGithub
{
    public class PulumiComponent
    {
        public PulumiComponent()
        {
                
        }

        public Dictionary<string,object?> CreateAzureResources()
        {
           Dictionary<string, object?> Output = new Dictionary<string, object?>();
           
            Console.WriteLine("Hello from Cosmos!");

            string task2 = "Hello from DynaTrace!";

            Console.WriteLine(task2);

//{content}

           return Output;
        }
    }
}
