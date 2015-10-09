using System;
using System.Collections.Generic;
using Theatre.Exceptions;

namespace Theatre.Contracts
{
    // Do not modify the interface members
    // Moving the interface to separate namespace is allowed
    // Adding XML documentation is allowed
    // TODO: document this interface definition
    public interface IPerformanceDatabase
    {
        
        /// <summary>
        /// Add theatre by given name. The theatre name is unique among all theatres.
        /// </summary>
        /// <param name="name">The name of the theatre</param>
        /// <exception cref="DuplicateTheatreException">Throw in case of duplicated theatre</exception>
        void AddTheatre(string name);

        /// <summary>
        /// List all theatres in the performance database.
        /// </summary>
        /// <returns>Return sequance of theatre's names, ordered alpabetically </returns>
        IEnumerable<string> ListTheatres();

        /// <summary>
        /// Addds a performance to the database.
        /// </summary>
        /// <param name="theatreName">Name of theatre wher the performance will be added.</param>
        /// <param name="performanceTitle">The title of the performance</param>
        /// <param name="startDateTime">Date and start time of the performance</param>
        /// <param name="duration">Duration of the performance.</param>
        /// <param name="price">Price of the performance.</param>
        /// <exception cref="TheatreNotFoundException">Thrown if name of the theatre does not exist in the database. 
        /// Holds a "Theatre does not exist" as error message.</exception>
        /// <exception cref="TimeDurationOverlapException">Thrown if there is ovelaping of the start and finish time
        /// between the perfomance we would like to add and any of the other perfomances in the theatre. 
        /// Holds a "Time/duration overlap" as error message.</exception>
        void AddPerformance(string theatreName, string performanceTitle, DateTime startDateTime, TimeSpan duration,
            decimal price);

        /// <summary>
        /// List of all performnaces in the database
        /// </summary>
        /// <returns>Returns sequance of all performances.</returns>
        IEnumerable<Performance> ListAllPerformances();

        /// <summary>
        /// List all performances for specific theatre.
        /// </summary>
        /// <param name="theatreName">Name of the theatre</param>
        /// <returns>Returns sequance of all performances for the requested theatre.</returns>
        IEnumerable<Performance> ListPerformances(string theatreName);
    }
}
