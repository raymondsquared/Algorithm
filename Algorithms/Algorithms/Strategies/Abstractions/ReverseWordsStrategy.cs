﻿using Algorithms.Abstrations;

namespace Algorithms.Strategies.Abstractions
{
    public abstract class ReverseWordsStrategy : IAlgorithmResolver
    {
        public CONSTANTS.ALGORITHM_TYPE GetAlgorithmType()
        {
            return CONSTANTS.ALGORITHM_TYPE.REVERSE_WORDS;
        }

        public string GetName()
        {
            return this.GetType().Name;
        }

        public abstract object Resolve(object input);

        public abstract CONSTANTS.DIFFICULTIES GetDifficulty();
    }
}
