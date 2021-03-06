﻿namespace SBS.BLL.Interfaces.Base
{
    public interface IGetSingleEntityOnlyBllBase<T>
    {
        /// <summary>
        /// Get an entity of the generically specified type matching the supplied ID
        /// </summary>
        /// <param name="id">The ID of the entity to retrieve</param>
        /// <returns>An entity of the generically specified type matching the supplied ID, or null if no match is found</returns>
        T Get(int id);
    }
}
