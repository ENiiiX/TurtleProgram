using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    class StoredProgram : ArrayList
    {
        private int counter = 0;

        private ArrayList variables = new ArrayList();
        private ArrayList variableNames = new ArrayList();

        public StoredProgram()
        {

        }

        public int Counter
        {
            set
            {
                if (value>=0 && value<Count)
                {
                    counter = value;
                }
            }
            get
            {
                return counter;
            }
        }
        public void AddVar(Var V)
        {
            variables.Add(V);
            variableNames.Add(V.VarName);
        }

        public override int Add(Object O)
        {
            int varIndex = 0;
            counter++;
            varIndex = base.Add(O);

            return varIndex;
        }
        /// <summary>
        /// Searches variables array for existing variable
        /// </summary>
        /// <param name="VarName"></param>
        /// <returns>Returns -1 if doesn't exist</returns>
        public int SearchVarname(String VarName)
        {
            VarName = VarName.Trim();
            for(int i = 0; i<variables.Count; i++)
            {
                Var v = (Var)variables[i];
                if (v.VarName.Equals(VarName))
                    return i;
            }
            return -1;
        }

        public int GetVarValue(String VarName)
        {
            int index = this.SearchVarname(VarName);
            if (index >= 0)
            {
                Var v = (Var)variables[index];
                return v.Value;
            }
            else
            {
                throw new ApplicationException("Variable doesn't exist");
            }
        }



    }
}
