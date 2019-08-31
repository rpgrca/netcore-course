    using System;

    namespace Consumer.Interfaces
    {
        /// <summary>
        /// Helper to convert from Json U to Adapter T
        /// </summary>
        public interface IAdapterFactory<T, U> {
            T Build(U source);
        }

    }
