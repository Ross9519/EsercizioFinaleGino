﻿using Retriever;

namespace DataHandler.Search
{
    public class CellphoneDataHandler : DataHandler
    {
        public CellphoneDataHandler(IContext context) : base(context) { }

        public override IEnumerable<string> Search(string word)
        {
            IEnumerable<Item> items = _context.GetAll();
            return items
                .Where(i => i.Name.Contains(word, StringComparison.CurrentCultureIgnoreCase) ||
                            i.Surname.Contains(word, StringComparison.CurrentCultureIgnoreCase))
                .Select(i => i.Mobile);
        }
    }
}