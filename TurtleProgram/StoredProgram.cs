using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleProgram
{
    public class StoredProgram : ArrayList
    {
        public Parser parser;
        Turtle turtle;

        private int counter = 0;
        private int loopStart;
        public bool loopFlag = false;
        public int loopSize = 0;
        public int iterations = 0;
        private ArrayList variables = new ArrayList();
        private ArrayList variableNames = new ArrayList();
        public List<Command> commands = new List<Command>();
        public List<Command> loopCommands = new List<Command>();
        public List<Command> ifCommands = new List<Command>();
        private int ifStart;
        public bool ifFlag = false;

        public StoredProgram(Turtle turtle)
        {
            this.turtle = turtle;
            parser = new Parser(turtle,this);
        }


        /// <summary>
        /// test
        /// </summary>
        /// <param name="O"></param>
        /// <returns></returns>
        public void AddCommand(Command O)
        {
            commands.Add(O);
            if(O is LoopCommand)
            {
                loopStart = counter;
                loopFlag = true;
                LoopCommand C = (LoopCommand)O;
                iterations = C.LoopAmount - 1;
            }
            else if (O is EndLoopCommand)
            {
                loopFlag = false;
                loopSize--;
            }
            else if (O is IfCommand)
            {
                ifStart = counter;
                loopFlag = true;
            }
            else if (O is EndIfCommand)
            {
                ifFlag = false;
            }

            if(loopFlag)
            {
                loopCommands.Add(O);
                loopSize++;
            }
            else if(ifFlag)
            {
                ifCommands.Add(O);
            }
            counter++;
        }


        public void Run()
        {
            for (int i = 0; i < counter; i++)
            {
                Command C = commands[i]; //If C is Expression - Direct Var to eval then?

                if(C is LoopCommand)
                {
                    for (int x = 0; x < iterations; x++)
                    {
                        foreach(Command X in loopCommands)
                        {
                            X.Execute();
                        }
                    }
                }
                if (C is IfCommand)
                {
                    for (int x = 0; x < iterations; x++)
                    {
                        foreach (Command X in ifCommands)
                        {
                            X.Execute();
                        }
                    }
                }
                else
                {
                    C.Execute();
                }
            }    
        }

        /// <summary>
        /// Clears the stored variables when the program is reset
        /// </summary>
        public void Reset()
        {
            counter = 0;
            variableNames.Clear();
            variables.Clear();
            commands.Clear();
            loopCommands.Clear();
            loopSize = 0;
            iterations = 0;
            counter = 0;
            this.Clear();
            turtle.reset();
        }





        //Variables

        /// <summary>
        /// Adds variables to ArrayLists for future access
        /// </summary>
        /// <param name="V">Variable object to be added to ArrayList</param>
        public void AddVar(Var V)
        {
            variables.Add(V);
            variableNames.Add(V.VarName);
        }

        /// <summary>
        /// Bool to see if variable name exists in ArrayList
        /// </summary>
        /// <param name="VarName">VarName to check in ArrayList</param>
        /// <returns>Returns true if VarName exists in ArrayList</returns>
        public bool VarExists(String VarName)
        {
            bool exists = false;
            if (variableNames.Contains(VarName))
            {
                exists = true;
                return exists;
            }
            else
            {
                return exists;
            }
        }


        /// <summary>
        /// Searches variables array for existing variable
        /// </summary>
        /// <param name="VarName"></param>
        /// <returns>Returns -1 if doesn't exist</returns>
        public int SearchVarName(String VarName)
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

        /// <summary>
        /// Gets value of variable given the variable name
        /// </summary>
        /// <param name="VarName">Variable name to search value of</param>
        /// <returns>Returns variable value</returns>
        public int GetVarValue(String VarName)
        {
            int index = this.SearchVarName(VarName);
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

        /// <summary>
        /// Sets value of existing variable
        /// </summary>
        /// <param name="VarName">Variable name to update</param>
        /// <param name="Value">New value of variable</param>
        public void SetVarValue(String VarName, int Value)
            {
            int index = this.SearchVarName(VarName);
            if (index >= 0)
            {
                Var v = (Var)variables[index];
                v.Value = Value;
            }
            else
            {
                throw new ApplicationException("Variable doesn't exist");
            }
        }

        public void SetVarExpression(String VarName, String Expression)
        {
            int index = this.SearchVarName(VarName);
            if (index >= 0)
            {
                Var v = (Var)variables[index];
                v.Expression = Expression;
            }
            else
            {
                throw new ApplicationException("Variable doesn't exist");
            }
        }


    }
}
