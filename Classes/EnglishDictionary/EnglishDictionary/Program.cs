using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary englishDictionary = new Dictionary("English");
            EnglishWord hello = new EnglishWord("hello");
            hello.AddDefinition("Used to express a greeting, answer a telephone, or attract attention.");
            hello.AddDefinition("Used derisively to question the comprehension, intelligence, or common sense of the person being addressed.");

            EnglishWord hi = new EnglishWord("hi");
            hi.AddDefinition("Used to express a greeting, answer a telephone, or attract attention.");
            hi.AddDefinition("Short version of the word 'Hello'.");
            hi.AddSynonym(hello);
            hello.AddSynonym(hi);

            EnglishWord goodbye = new EnglishWord("goodbye");
            goodbye.AddDefinition("farewell (a conventional expression used at parting).");
            goodbye.AddAntonym(hello);
            goodbye.AddAntonym(hi);
            englishDictionary.AddWord(hello);
            englishDictionary.AddWord(hi);
            englishDictionary.AddWord(goodbye);


            Console.Write("\nDefinition of 'goodbye' word: ");
            PrintCollection(englishDictionary.GetWordDefinitions("goodbye"));
            Console.Write("\n\nAntonyms of 'goodbye' word: ");
            PrintCollection(englishDictionary.GetWordAntonyms("goodbye"));
            Console.ReadKey();

        }

        public static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach(var item in collection)
            {
                Console.Write("\n" + item.ToString());
            }
        }
    }

    public class Dictionary
    {
        public string language;
        private Dictionary<string, EnglishWord> words;

        public Dictionary(string language)
        {
            this.language = language;
            this.words = new Dictionary<string, EnglishWord>();
        }

        public string Language
        {
            get { return this.language; }
        }

        public Dictionary<string, EnglishWord> Words
        {
            get { return this.words; }
        }

        public void AddWord(EnglishWord word)
        {
            if (word != null && word.Word.Length != 0)
            {
                this.words.Add(word.Word, word);
            }
        }

        public HashSet<string> GetWordForms(string word)
        {
            if (this.words.ContainsKey(word))
                return words[word].Forms;
            return null;
        }

        public HashSet<string> GetWordDefinitions(string word)
        {
            if (this.words.ContainsKey(word))
                return words[word].Definitions;
            return null;
        }

        public HashSet<EnglishWord> GetWordSynonyms(string word)
        {
            if (this.words.ContainsKey(word))
                return words[word].Synonyms;
            return null;
        }

        public HashSet<EnglishWord> GetWordAntonyms(string word)
        {
            if (this.words.ContainsKey(word))
                return words[word].Antonyms;
            return null;
        }
    }

    public class EnglishWord
    {
        private string word;
        private HashSet<string> definitions;
        private HashSet<string> forms;
        private HashSet<EnglishWord> synonyms;
        private HashSet<EnglishWord> antonyms;

        //constructors
        public EnglishWord(string word)
        {
            this.word = word;
            this.definitions = new HashSet<string>();
            this.forms = new HashSet<string>();
            this.synonyms = new HashSet<EnglishWord>();
            this.antonyms = new HashSet<EnglishWord>();
        }

        public EnglishWord(string word, string definition)
        {
            this.word = word;
            this.definitions = new HashSet<string>(){definition};
            this.forms = new HashSet<string>();
            this.synonyms = new HashSet<EnglishWord>();
            this.antonyms = new HashSet<EnglishWord>();
        }

        //properties
        public string Word
        {
            get { return this.word; }
        }

        public HashSet<string> Definitions
        {
            get { return this.definitions; }
        }

        public HashSet<string> Forms
        {
            get { return this.forms; }
        }

        public HashSet<EnglishWord> Synonyms
        {
            get { return this.synonyms; }
        }

        public HashSet<EnglishWord> Antonyms
        {
            get { return this.antonyms; }
        }

        //methods
        public void AddDefinition(string definition)
        {
            if (definition != null && definition.Length != 0)
            {
                this.definitions.Add(definition);
            }
        }

        public void AddForm(string form)
        {
            if (form != null && form.Length != 0)
            {
                this.forms.Add(form);
            }
        }

        public void AddSynonym(EnglishWord synonym)
        {
            if (synonym != null)
            {
                this.synonyms.Add(synonym);
            }
        }

        public void AddAntonym(EnglishWord antonym)
        {
            if (antonym != null)
            {
                this.antonyms.Add(antonym);
            }
        }

        public override string ToString()
        {
            return this.Word;
        }

        public void PrintWord()
        {
            string result = "\n\nWord: " + this.word;
            if (this.definitions.Count != 0)
            {
                result += "\n\nDefinitions: ";
                foreach(string definition in this.definitions)
                {
                    result += ("\n- " + definition + " ");
                }
            }
            if (this.forms.Count != 0)
            {
                result += "\n\nForms: ";
                foreach (string form in this.forms)
                {
                    result += ("\n- " + form + " ");
                }
            }
            if (this.synonyms.Count != 0)
            {
                result += "\n\nSynonyms: ";
                foreach (var synonym in this.synonyms)
                {
                    result += ("\n- " + synonym.word + " ");
                }
            }
            if (this.antonyms.Count != 0)
            {
                result += "\n\nAntonym: ";
                foreach (var antonym in this.antonyms)
                {
                    result += ("\n- " + antonym.word + " ");
                }
            }
            Console.Write(result);
        }

    }

}
