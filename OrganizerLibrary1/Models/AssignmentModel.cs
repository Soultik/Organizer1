using System;
using System.Collections.Generic;
using System.Text;

namespace OrganizerLibrary.Models
{
    public class AssignmentModel
    {
        /// <summary>
        /// The unique identifier for assignments.
        /// </summary>
        public int GeneralAssignmentId { get; set; }
        /// <summary>
        /// Name of that assignment.
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Boolean value used to determine if we're done with that assignment.
        /// </summary>
        public bool IsDone { get; set; }
        /// <summary>
        /// When was this assignment added.
        /// </summary>
        public DateTime DateAdded { get; set; }
        /// <summary>
        /// When it is supposed to be finished.
        /// </summary>
        public DateTime DateToFinish { get; set; }
        /// <summary>
        /// Constructor with 4 parameters.
        /// </summary>
        /// <param name="comment">Comment.</param>
        /// <param name="finishedState">is it done?</param>
        /// <param name="now">Date/time when the assignment is added.</param>
        /// <param name="dateFinish">When it is supposed to be finished.</param>
        public AssignmentModel(string comment, bool finishedState, DateTime now, DateTime dateFinish)
        {
            this.Comment = comment;
            this.IsDone = finishedState;
            this.DateAdded = now;
            this.DateToFinish = dateFinish;
        }
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public AssignmentModel()
        {

        }


    }
}
