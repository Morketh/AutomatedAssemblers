using Sandbox.Game.EntityComponents;
using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using SpaceEngineers.Game.ModAPI.Ingame;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System;
using VRage.Collections;
using VRage.Game.Components;
using VRage.Game.ModAPI.Ingame;
using VRage.Game.ObjectBuilders.Definitions;
using VRage.Game;
using VRageMath;

namespace IngameScript
{
    partial class Program : MyGridProgram
    {
        string AutomatedAssemblerTAG = "[AI]";
        public Program()
        {
            // The constructor, called only once every session and
            // always before any other method is called. Use it to
            // initialize your script. 
            //     
            // The constructor is optional and can be removed if not
            // needed.
        }

        public void Save()
        {
            // Called when the program needs to save its state. Use
            // this method to save your state to the Storage field
            // or some other means. 
            // 
            // This method is optional and can be removed if not
            // needed.
        }

        public void Main()
        {
            List<IMyAssembler> blocks = new List<IMyAssembler>();
            GridTerminalSystem.GetBlocksOfType(blocks);

            for (int i = 0; i < blocks.Count; i++)
            {
                Echo("Total Blocks Found: "+blocks.Count.ToString());
                Echo("Is AI: "+blocks[i].CustomName.StartsWith(AutomatedAssemblerTAG));
                Echo("Full Name: " + blocks[i].CustomName);

                if (blocks[i].CustomName.StartsWith(AutomatedAssemblerTAG))
                {
                    // Get INI Config from Assembler Custom Data
                }
            }
        }
    }
}