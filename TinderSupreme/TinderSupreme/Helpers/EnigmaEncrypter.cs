using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinderSupreme.Helpers
{
    public class EnigmaEncrypter
    {
        private static String keyPhrase = "B3af%s_R!J%rDw_DPq2sKkbUQdmwteVeFWU^9g8GsRZ-u_CqtUKbBU&u$NGaQGxG!hK$fc2TK@qGeXgN4HdsPxsT_8tzhK=8LLXz_9RXC!rCAryM-x9-&#s42$rMPZ@e^CCb!-g#D!sNj=BQGgmfA*mq3*MM-=BDUvN%J-XN5Q=BV3h2r=kAwbNE39+qxDCgUs5EtZJUc-2^@?B$qsGCWdbbGmjVDe@eQcD^@!nd4fqtEg3cRVw&TZ+UXtqW3Pr9";
        private static int multiplicator = 7; 

        public static String Encryptor(String original)
        {
            String generatedPass = "";

            foreach(int key in keyPhrase)
            {
                int encryptChar = key;
                foreach (int okey in original)
                {
                    encryptChar = (encryptChar ^ okey) * multiplicator;
                }
                generatedPass += (char)(encryptChar%256);
            }

            return generatedPass;

        }
    }
}