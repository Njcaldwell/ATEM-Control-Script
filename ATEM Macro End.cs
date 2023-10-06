// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

using BMDSwitcherAPI;
using System.Diagnostics;

namespace SimpleSwitcher
{
    class Program
    {
        static long GetInputId(IBMDSwitcherInput input)
        {
            input.GetInputId(out long id);
            return id;
        }

        static void Main(string[] args)
        {
            // Create switcher discovery object
            IBMDSwitcherDiscovery discovery = new CBMDSwitcherDiscovery();
            IBMDSwitcherDiscovery discovery2 = new CBMDSwitcherDiscovery();
            IBMDSwitcherDiscovery discovery3 = new CBMDSwitcherDiscovery();

            //Switcher IP List Out
            string atemSW1 = "10.200.9.243";
            string atemSW2 = "10.200.9.244";
            string atemSW3 = "10.200.9.245";



            // Switcher Discovery
            discovery.ConnectTo(atemSW1, out IBMDSwitcher switcher, out _BMDSwitcherConnectToFailure failureReason);
            Console.WriteLine("Connected to switcher ATEM 1: " + atemSW1);

            discovery2.ConnectTo(atemSW2, out IBMDSwitcher switcher2, out _BMDSwitcherConnectToFailure failureReason2);
            Console.WriteLine("Connected to switcher ATEM 2: " + atemSW2);


            discovery3.ConnectTo(atemSW3, out IBMDSwitcher switcher3, out _BMDSwitcherConnectToFailure failureReason3);
            Console.WriteLine("Connected to switcher ATEM 3: " + atemSW3 + Environment.NewLine);

            //ATEM Switcher Connection Variable
            var atem = new AtemSwitcher(switcher);
            var atem2 = new AtemSwitcher(switcher2);
            var atem3 = new AtemSwitcher(switcher3);


            // Get reference to various objects

            //ATEM 1 
            IBMDSwitcherMixEffectBlock me0 = atem.MixEffectBlocks.First();
            IBMDSwitcherTransitionParameters me0TransitionParams = me0 as IBMDSwitcherTransitionParameters;
            IBMDSwitcherTransitionWipeParameters me0WipeTransitionParams = me0 as IBMDSwitcherTransitionWipeParameters;

            IBMDSwitcherMixEffectBlock me1 = atem.MixEffectBlocks.Last();
            IBMDSwitcherTransitionParameters me1TransitionParams = me1 as IBMDSwitcherTransitionParameters;
            IBMDSwitcherTransitionWipeParameters me1WipeTransitionParams = me1 as IBMDSwitcherTransitionWipeParameters;

            //ATEM 2
            IBMDSwitcherMixEffectBlock me2 = atem2.MixEffectBlocks.First();
            IBMDSwitcherTransitionParameters me2TransitionParams = me2 as IBMDSwitcherTransitionParameters;
            IBMDSwitcherTransitionWipeParameters me2WipeTransitionParams = me2 as IBMDSwitcherTransitionWipeParameters;

            IBMDSwitcherMixEffectBlock me3 = atem2.MixEffectBlocks.Last();
            IBMDSwitcherTransitionParameters me3TransitionParams = me3 as IBMDSwitcherTransitionParameters;
            IBMDSwitcherTransitionWipeParameters me3WipeTransitionParams = me3 as IBMDSwitcherTransitionWipeParameters;

            //ATEM 3
            IBMDSwitcherMixEffectBlock me4 = atem3.MixEffectBlocks.First();
            IBMDSwitcherTransitionParameters me4TransitionParams = me4 as IBMDSwitcherTransitionParameters;
            IBMDSwitcherTransitionWipeParameters me4WipeTransitionParams = me4 as IBMDSwitcherTransitionWipeParameters;

            IBMDSwitcherMixEffectBlock me5 = atem3.MixEffectBlocks.Last();
            IBMDSwitcherTransitionParameters me5TransitionParams = me5 as IBMDSwitcherTransitionParameters;
            IBMDSwitcherTransitionWipeParameters me5WipeTransitionParams = me5 as IBMDSwitcherTransitionWipeParameters;


            IBMDSwitcherInput input1 = atem.SwitcherInputs
                                        .Where((i, ret) =>
                                        {
                                            i.GetPortType(out _BMDSwitcherPortType type);
                                            return type == _BMDSwitcherPortType.bmdSwitcherPortTypeExternal;
                                        })
                                        .ElementAt(0);

            IBMDSwitcherInput input2 = atem.SwitcherInputs
                                      .Where((i, ret) =>
                                      {
                                          i.GetPortType(out _BMDSwitcherPortType type);
                                          return type == _BMDSwitcherPortType.bmdSwitcherPortTypeExternal;
                                      })
                                      .ElementAt(1);
            IBMDSwitcherInput input3 = atem.SwitcherInputs
                                      .Where((i, ret) =>
                                      {
                                          i.GetPortType(out _BMDSwitcherPortType type);
                                          return type == _BMDSwitcherPortType.bmdSwitcherPortTypeExternal;
                                      })
                                      .ElementAt(2);

            IBMDSwitcherInput input4 = atem.SwitcherInputs
                                      .Where((i, ret) =>
                                      {
                                          i.GetPortType(out _BMDSwitcherPortType type);
                                          return type == _BMDSwitcherPortType.bmdSwitcherPortTypeExternal;
                                      })
                                      .ElementAt(3);

            IBMDSwitcherInput input5 = atem.SwitcherInputs
                                     .Where((i, ret) =>
                                     {
                                         i.GetPortType(out _BMDSwitcherPortType type);
                                         return type == _BMDSwitcherPortType.bmdSwitcherPortTypeExternal;
                                     })
                                     .ElementAt(4);

            IBMDSwitcherInput input6 = atem.SwitcherInputs
                                     .Where((i, ret) =>
                                     {
                                         i.GetPortType(out _BMDSwitcherPortType type);
                                         return type == _BMDSwitcherPortType.bmdSwitcherPortTypeExternal;
                                     })
                                     .ElementAt(5);

            IBMDSwitcherInput input7 = atem.SwitcherInputs
                                     .Where((i, ret) =>
                                     {
                                         i.GetPortType(out _BMDSwitcherPortType type);
                                         return type == _BMDSwitcherPortType.bmdSwitcherPortTypeExternal;
                                     })
                                     .ElementAt(6);

            IBMDSwitcherInput input8 = atem.SwitcherInputs
                                     .Where((i, ret) =>
                                     {
                                         i.GetPortType(out _BMDSwitcherPortType type);
                                         return type == _BMDSwitcherPortType.bmdSwitcherPortTypeExternal;
                                     })
                                     .ElementAt(7);

            IBMDSwitcherInput SuperSource = atem.SwitcherInputs
                                     .Where((i, ret) =>
                                     {
                                         i.GetPortType(out _BMDSwitcherPortType type);
                                         return type == _BMDSwitcherPortType.bmdSwitcherPortTypeSuperSource;

                                     })

                                     .ElementAt(0);

            string currentTime = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);

            Console.WriteLine(currentTime);



            // Setup the transition
            Console.WriteLine("Setting preview input" + Environment.NewLine);

            //ATEM1
            me0.SetPreviewInput(GetInputId(input1));
            me1.SetPreviewInput(GetInputId(input1));
            Console.WriteLine("ATEM1 Preview Input Set");


            //ATEM2
            me2.SetPreviewInput(GetInputId(input1));
            me3.SetPreviewInput(GetInputId(input1));
            Console.WriteLine("ATEM2 Preview Input Set");


            //ATEM3
            me4.SetPreviewInput(GetInputId(input1));
            me5.SetPreviewInput(GetInputId(input1));
            Console.WriteLine("ATEM3 Preview Input Set" + Environment.NewLine);

            /*
            Console.WriteLine("Setting next transition selection");
            me0TransitionParams.SetNextTransitionSelection(_BMDSwitcherTransitionSelection.bmdSwitcherTransitionSelectionBackground);
            */
            Console.WriteLine("Setting Swipe Parameters FlipFlop");
            //me1TransitionParams.SetNextTransitionSelection(_BMDSwitcherTransitionWipeParametersEventType.bmdSwitcherTransitionWipeParametersEventTypeFlipFlopChanged);


            Console.WriteLine("Setting next transition style" + Environment.NewLine);

            //ATEM 1
            me0TransitionParams.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleWipe);
            me1TransitionParams.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleWipe);
            Console.WriteLine("ATEM 1 Transition style set");

            //ATEM 2
            me2TransitionParams.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleWipe);
            me3TransitionParams.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleWipe);
            Console.WriteLine("ATEM 2 Transition style set");

            //ATEM 3
            me4TransitionParams.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleWipe);
            me5TransitionParams.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleWipe);
            Console.WriteLine("ATEM 3 Transition style set" + Environment.NewLine);

            //Console.WriteLine("Setting transition style");
            //me0WipeTransitionParams.SetPattern(_BMDSwitcherPatternStyle.bmdSwitcherPatternStyleRectangleIris);


            //ATEM Transitions


            //ATEM Transition Rate
            Console.WriteLine("Setting transition rate" + Environment.NewLine);

            UInt32 rateSet1 = 30;
            UInt32 rateSet2 = 25;


            //ATEM 1
            me0WipeTransitionParams.SetRate(rateSet1);
            me1WipeTransitionParams.SetRate(rateSet1);
            Console.WriteLine("ATEM1 ME1 Rate Set: " + rateSet1);
            Console.WriteLine("ATEM1 ME2 Rate Set: " + rateSet1 + Environment.NewLine);

            //ATEM 2
            me2WipeTransitionParams.SetRate(rateSet2);
            me3WipeTransitionParams.SetRate(rateSet1);
            Console.WriteLine("ATEM2 ME1 Rate Set: " + rateSet2);
            Console.WriteLine("ATEM2 ME2 Rate Set: " + rateSet1 + Environment.NewLine);

            //ATEM3
            me4WipeTransitionParams.SetRate(rateSet1);
            me5WipeTransitionParams.SetRate(rateSet1);
            Console.WriteLine("ATEM3 ME1 Rate Set: " + rateSet1);
            Console.WriteLine("ATEM3 ME2 Rate Set: " + rateSet1 + Environment.NewLine);

            uint mInput;
            mInput = 0;

            Console.WriteLine("Running Macro: " + mInput);



            //Convert.ToUInt32(Console.ReadLine());


            atem.RunMacro(mInput);
            atem2.RunMacro(mInput);
            atem3.RunMacro(mInput);

            // Perform the transition
            //Console.WriteLine("Performing auto transition");
            // me0.PerformAutoTransition();
            // me1.PerformAutoTransition();

            System.Threading.Thread.Sleep(1000);

            /*
            Console.Write("Press ENTER to exit...");
            Console.ReadLine();
            */

        }
    }

    internal class AtemSwitcher
    {
        private IBMDSwitcher switcher;

        public AtemSwitcher(IBMDSwitcher switcher) => this.switcher = switcher;

        public IEnumerable<IBMDSwitcherMixEffectBlock> MixEffectBlocks
        {
            get
            {
                // Create a mix effect block iterator
                switcher.CreateIterator(typeof(IBMDSwitcherMixEffectBlockIterator).GUID, out IntPtr meIteratorPtr);
                IBMDSwitcherMixEffectBlockIterator meIterator = Marshal.GetObjectForIUnknown(meIteratorPtr) as IBMDSwitcherMixEffectBlockIterator;
                if (meIterator == null)
                    yield break;

                // Iterate through all mix effect blocks
                while (true)
                {
                    meIterator.Next(out IBMDSwitcherMixEffectBlock me);

                    if (me != null)
                        yield return me;
                    else
                        yield break;
                }
            }
        }



        public IEnumerable<IBMDSwitcherInput> SwitcherInputs
        {
            get
            {
                // Create an input iterator
                switcher.CreateIterator(typeof(IBMDSwitcherInputIterator).GUID, out IntPtr inputIteratorPtr);
                IBMDSwitcherInputIterator inputIterator = Marshal.GetObjectForIUnknown(inputIteratorPtr) as IBMDSwitcherInputIterator;
                if (inputIterator == null)
                    yield break;

                // Scan through all inputs
                while (true)
                {
                    inputIterator.Next(out IBMDSwitcherInput input);

                    if (input != null)
                        yield return input;
                    else
                        yield break;
                }
            }
        }

        public uint GetMacroCount()
        {

            uint macroCount;
            IBMDSwitcherMacroPool switcherMacroPool = (IBMDSwitcherMacroPool)this.switcher;
            switcherMacroPool.GetMaxCount(out macroCount);
            return macroCount;
        }
        public string GetMacro(uint index)
        {

            string macroName;
            IBMDSwitcherMacroPool switcherMacroPool = (IBMDSwitcherMacroPool)this.switcher;
            switcherMacroPool.GetDescription(index, out macroName);
            return macroName;
        }

        public int RunMacro(uint index)
        {

            IBMDSwitcherMacroControl switcherMacroControl = (IBMDSwitcherMacroControl)this.switcher;
            switcherMacroControl.Run(index);
            return Convert.ToInt32(index);
        }


    }
}

