using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Ponderizer.Library.Content.Reference
{
    [Serializable]
    enum Source { SCRIPTURE, GENERAL_CONFERENCE, BOOK, MANUAL, MAGAZINE, OTHER };

    [Serializable]
    class Reference
    {
        public Source source { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string chapter { get; set; }
        public string verse { get; set; }

        public Reference() { }
        public Reference(Source source, string name)
        {
            this.source = source;
            this.name = name;
        }
        public Reference(Source source, string name, string title, string author) : this(source, name)
        {
            this.title = title;
            this.author = author;
        }
        public Reference(Source source, string name, string title, string chapter, string verse) : this(source, name)
        {
            this.title = title;
            this.chapter = chapter;
            this.verse = verse;
        }

    }
}
