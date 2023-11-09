using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    internal class Undo
    {
        public string flagMode { get; set; }

        public string primaryKey { get; set; }

        public object dataRow { get; set; }

        public Undo() { }

        public Undo(string flagMode)
        {
            this.flagMode = flagMode;
        }

        public Undo(string flagMode, string primaryKey)
        {
            this.flagMode = flagMode;
            this.primaryKey = primaryKey;
        }

        public Undo(string flagMode, string primaryKey, object dataRow)
        {
            this.flagMode = flagMode;
            this.primaryKey = primaryKey;
            this.dataRow = dataRow;
        }
    }
}
