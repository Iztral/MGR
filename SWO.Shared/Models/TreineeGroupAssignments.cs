using SWO.Shared.Abstractions.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWO.Shared.Models
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
        public virtual Member Member { get; set; }
        public virtual TraineeGroup TraineeGroup { get; set; }
        #endregion
    }
}
