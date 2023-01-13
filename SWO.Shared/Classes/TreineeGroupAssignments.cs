using SWO.Shared.Classes.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Classes
{
    public class TreineeGroupAssignments : BaseModel
    {
        [ForeignKey("Member")]
        public int MemberID { get; set; }

        [ForeignKey("TraineeGroup")]
        public int GroupID { get; set; }

        public TreineeGroupAssignments()
        {

        }

        public TreineeGroupAssignments(int memberId, int groupID)
        {
            MemberID = memberId;
            GroupID = groupID;
        }

        #region EF
        public virtual ApplicationUser Member { get; set; }
        public virtual TraineeGroup TraineeGroup { get; set; }
        #endregion
    }
}
