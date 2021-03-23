
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    struct RequestItem
    {

        public int Count { get; set; }
        public Article Article_ { get; set; }
        public RequestItem(Article article, int count)
        {
            this.Article_ = article;
            this.Count = count;
        }
        public override string ToString()
        {
            return $"RequestItem\n{Article_}, Count: {Count}";
        }

    }
}
