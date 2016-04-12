using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPWarsztat.HelpClass;
namespace DSPWarsztat.Model
{
    public class NotesModel 
    {
        public String NoteName { get; set; }
        public String CreateTime { get; set; }

        public NotesModel(string name, string createTime)
        {
            NoteName = name;
            CreateTime = createTime;
        }
    }
}
