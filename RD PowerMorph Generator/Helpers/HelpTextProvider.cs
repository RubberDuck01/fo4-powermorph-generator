using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RD_PowerMorph_Generator.Helpers {
    internal class HelpTextProvider {
        internal static string HelpLoadXmls() {
            return
                "In order to generate BodyGen files, you must provide a path to directory where all your body presets (XMLs) are.\n\n" +
                "Use the 'Load XML Sliders' button to provide a path to the directory containing all your body presets.\n\n" +
                "Then, optionally, use the 'Load target body XML' to load a specific body preset (XML). This should be your default preset (the one you've used to build all the meshes).\n\n" +
                "Keep in mind: if you don't load your default body preset, you won't be able to patch the generated files!\n\n" +
                "If you're using two (2) body presets (one preset for Nude body, the other for clothes and outfits), it is reccommended to use the NUDE body preset.";
        }

        internal static string HelpGenerate() {
            return
                "These controls are used to generate your own BodyGen files (morphs.ini and templates.ini).\n\n" +
                "First, you must set target output directory. This is the directory where your newly generated 'morphs.ini' and 'templates.ini' files will be saved. Use the 'Select Output Directory' button.\n\n" +
                "You're able to tweak the settings to your liking. Check the GitHub Wiki for detailed information!\n\n" +
                "To start the generation process, click 'Generate BodyGen Files' button. A progress bar will indicate the progress.\n" +
                "Do keep in mind: you shouldn't generate BodyGen files for more than 128 body presets. It's an engine limitation (of the game, not this tool).";
        }

        internal static string HelpUpdate() {
            return
                "If you've built all your in-game meshes WITHOUT using ZEROED SLIDERS body preset (all sliders are 0), then you should use update the newly generated BodyGen files.\n\n" +
                "This 'Update' function tweaks the provided body presets (the ones used in generation) to be 'based' on target (default) body preset.\nThis function is only available after generation, and you must've provided the path to target body XML.\n\n" +
                "Once you initiate 'Update' function, the tool will update and automatically save changes to the newly generated BodyGen files. A progress bar can be used to track the progress, but you will receive a popup notification once it finishes its task.\n\n" +
                "For detailed information on the topic, check the GitHub Wiki!";
        }

        internal static string HelpLoadedXmlsData() {
            return
                "A basic information is displayed here, such as total count for all your loaded preset files, as well as the name of your target (default) body preset.";
        }
    }
}
