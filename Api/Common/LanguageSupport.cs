using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Language
{
    public class LanguageSupport
    {
        public string CheckLanguage(string input)
        {
            string _retval = LanguageCode.English;
            // check
            string _inputCheck = input.ToLower();
            LanguageVietnameseKeywordDetect _v = new LanguageVietnameseKeywordDetect();
            foreach (string item in _v.Keyword)
            {
                if(_inputCheck.Contains(item.ToLower()))
                {
                    _retval = LanguageCode.Vietnamese;
                    return _retval;
                }
            }
           
            return _retval;
        }
    }
}