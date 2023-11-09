using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    class Redo
    {
        public string flagMode { get; set; }

        public string primaryKey { get; set; }

        public object dataRow { get; set; }

        public Redo() { }

        public Redo(string flagMode)
        {
            this.flagMode = flagMode;
        }

        public Redo(string flagMode, string primaryKey)
        {
            this.flagMode = flagMode;
            this.primaryKey = primaryKey;
        }

        public Redo(string flagMode, string primaryKey, object dataRow)
        {
            this.flagMode = flagMode;
            this.primaryKey = primaryKey;
            this.dataRow = dataRow;
        }
    }
}
