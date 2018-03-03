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
            // Scan for assembler starting with [AI]
            // check for BLANK Custom Data
                // If True Write Default INI template to Assembler CD
                // Else Ignore (It must already have been initilized so lets not erase any potential modifications)
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
                    // IF AutoLCDInstall is True 
                        // (Look for LCD Panel starting with [AI])
                        // Change name to "[LCD] Assembler Qoutas"
                        // If Quota Overrides are enabled
                        // Set Custom Data to "Inventory T:FILTER_VAR +component +ITEM:VALUE
                        // Loop through all INI configured Key:Value pairs
                    // Else
                        // Set Custom Data to "Inventory T:* +component"
                        // Set AutoLCD to True (AutoLCDInstall overrides INI Config)

                    // If AutoLCD is True pull quotas from Mmasters Automatic LCD2 Inventory Command (advanced feature)
                        // parse itemcount/maxitems from LCD
                        // maxitems - itemcount = QuedItems

                    // IF AssemblerMode (From INI) is Single
                        // Set up entire Que on this device
                    // Else switch(key)
                        // Case ComponentName
                        // que item "ComponentName" name only
                }
            }
        }
    }
}