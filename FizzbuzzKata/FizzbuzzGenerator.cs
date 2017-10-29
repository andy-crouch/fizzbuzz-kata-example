using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzbuzzKata
{
    public class FizzbuzzGenerator
    {
        List<INumberParser> _numberParsers;

        public List<string> GenerateResultsBetween(int rangeStart, int rangeEnd)
        {
            var resultSet = new List<string>();
            var inputRange = Enumerable.Range(rangeStart, rangeEnd).ToList();

            inputRange.ForEach(i =>
            {
                INumberParser numberParser
                    = Parsers
                        .First(p => i % p.Divisor == 0);

                resultSet.Add(numberParser.Parse(i));
            });

            return resultSet;
        }

        private List<INumberParser> Parsers
        {
            get
            {
                if (_numberParsers != null)
                    return _numberParsers;

                var interfaceType = typeof(INumberParser);
                return _numberParsers 
                    = AppDomain.CurrentDomain.GetAssemblies()
                         .SelectMany(x => x.GetTypes())
                         .Where(x => interfaceType.IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                         .Select(x => Activator.CreateInstance(x))
                         .Cast<INumberParser>()
                         .OrderByDescending(p => p.Divisor)
                         .ToList();
            }
        }
    }
}
