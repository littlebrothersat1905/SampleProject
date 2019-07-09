using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Windows.Forms;

namespace DemoGUI
{
    public sealed class IPyHandler
    {

        // Thread-safety
        private static IPyHandler instance = null;
        private static readonly object Padlock = new object();

      

        // @params
        private string _pathToDLL;
        private ScriptEngine engine;


        private IPyHandler() {
            this.engine = Python.CreateEngine();
        }

        public static IPyHandler Instance {
            get {
                lock (Padlock) {
                    if (instance == null) {
                        instance = new IPyHandler();
                    }
                    return instance;
                }
            }
        }

        public string IPyPath { get; set; }

        public void setIPy() {
            if (IPyPath is null)
            {
                MessageBox.Show("IronPython is not set.", "Warning");
            }
            else {
                var tempPath = engine.GetSearchPaths();
                tempPath.Add(IPyPath);
                this.engine.SetSearchPaths(tempPath);
            }
        }

        public dynamic setPython(string pathToPy) {
            try {
                this.setIPy();
            } catch { }
            dynamic executePy = this.engine.ExecuteFile(pathToPy);
            return executePy;
        }
        

    }
}
