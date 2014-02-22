using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanguageEnhancement
{
    public class ObjectInitializerClass
    {
        public static ProcessData ObjectOld()
        {
            ProcessData data = new ProcessData();
            data.Id = 123;
            data.Name = "LinqInAction";
            data.Memory = 1024 * 1024;
            return data;
        }

        public static ProcessData ObjectInitializer()
        {
            ProcessData data = new ProcessData{
                Id = 123,
                Name = "LinqInAction",
                Memory = 1024 * 1024
            };
            return data;
        }

        public static void ObjectWithParamOld()
        {
            var exception = new Exception("Message");
            exception.Source = "Linq In Action";
            throw exception;
        }

        public static void ObjectWithParamInitializer()
        {
            throw new Exception("message") { Source = "Linq In Action" };
        }

        public List<ProcessData> CollectionOld()
        {
            List<ProcessData> lstProcesses = new List<ProcessData>();
            ProcessData process = new ProcessData();
            process.Id = 1;
            process.Name = "devenv";
            lstProcesses.Add(process);
            process = new ProcessData();
            process.Id = 2;
            process.Name = "firefox";
            lstProcesses.Add(process);
            return lstProcesses;
        }

        public List<ProcessData> CollectionInitializer()
        {
            var lstProcesses = new List<ProcessData> { 
                 new ProcessData { Id = 1, Name = "devenv" },
                 new ProcessData { Id = 2, Name = "firefox" }
            };
            return lstProcesses;
        }

    }
}
