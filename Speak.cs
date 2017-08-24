using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;

namespace SoftGrow
{
    public class Speak
    {
        SpeechSynthesizer reader;

        public void SayIt(string vWhere)
        {
            try
            {                
                    reader = new SpeechSynthesizer();
                    reader.SpeakAsync(vWhere);
                
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }

    }
}
