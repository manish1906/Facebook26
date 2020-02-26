using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.Models.Enums.Main;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("FacebookUsers",Schema="dbo")]
    public partial class FacebookUser
    {
		#region UserID Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserID Annotations

        public int UserID { get; set; }

		#region FirstName Annotations

        [Required]
        [MaxLength(50)]
		#endregion FirstName Annotations

        public string FirstName { get; set; }

		#region LastName Annotations

        [Required]
        [MaxLength(50)]
		#endregion LastName Annotations

        public string LastName { get; set; }

		#region MobileNo Annotations

        [Required]
		#endregion MobileNo Annotations

        public long MobileNo { get; set; }

		#region Email Annotations

        [Required]
        [MaxLength(50)]
		#endregion Email Annotations

        public string Email { get; set; }

		#region Password Annotations

        [Required]
        [MaxLength(200)]
		#endregion Password Annotations

        public string Password { get; set; }

		#region DateOfBirth Annotations

        [Required]
		#endregion DateOfBirth Annotations

        public System.DateTime DateOfBirth { get; set; }

		#region GenderAO Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FBApplicationObjects","dbo","","GenderAO")]
		#endregion GenderAO Annotations

        public int GenderAO { get; set; }

		#region CreatedDateTime Annotations

        [Required]
		#endregion CreatedDateTime Annotations

        public System.DateTimeOffset CreatedDateTime { get; set; }

		#region LoginStatus Annotations

        [Required]
		#endregion LoginStatus Annotations

        public bool LoginStatus { get; set; }

		#region FBApplicationObject Annotations

        [ForeignKey(nameof(GenderAO))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FBApplicationObject.FacebookUsers))]
		#endregion FBApplicationObject Annotations

        public virtual FBApplicationObject FBApplicationObject { get; set; }

		#region Posts Annotations

        [InverseProperty("FacebookUser")]
		#endregion Posts Annotations

        public virtual ICollection<Post> Posts { get; set; }

		#region PostMessages Annotations

        [InverseProperty("FacebookUser")]
		#endregion PostMessages Annotations

        public virtual ICollection<PostMessage> PostMessages { get; set; }

		#region ChatMedia Annotations

        [InverseProperty("FacebookUser")]
		#endregion ChatMedia Annotations

        public virtual ICollection<ChatMedia> ChatMedia { get; set; }

		#region ChatMedia1 Annotations

        [InverseProperty("FacebookUser1")]
		#endregion ChatMedia1 Annotations

        public virtual ICollection<ChatMedia> ChatMedia1 { get; set; }

		#region ChatMessages Annotations

        [InverseProperty("FacebookUser")]
		#endregion ChatMessages Annotations

        public virtual ICollection<ChatMessage> ChatMessages { get; set; }

		#region ChatMessages1 Annotations

        [InverseProperty("FacebookUser1")]
		#endregion ChatMessages1 Annotations

        public virtual ICollection<ChatMessage> ChatMessages1 { get; set; }

		#region CoverPhotos Annotations

        [InverseProperty("FacebookUser")]
		#endregion CoverPhotos Annotations

        public virtual ICollection<CoverPhoto> CoverPhotos { get; set; }

		#region EducationDetails Annotations

        [InverseProperty("FacebookUser")]
		#endregion EducationDetails Annotations

        public virtual ICollection<EducationDetail> EducationDetails { get; set; }

		#region LogActivities Annotations

        [InverseProperty("FacebookUser")]
		#endregion LogActivities Annotations

        public virtual ICollection<LogActivity> LogActivities { get; set; }

		#region PostComments Annotations

        [InverseProperty("FacebookUser")]
		#endregion PostComments Annotations

        public virtual ICollection<PostComment> PostComments { get; set; }

		#region PostLikes Annotations

        [InverseProperty("FacebookUser")]
		#endregion PostLikes Annotations

        public virtual ICollection<PostLike> PostLikes { get; set; }

		#region PostShares Annotations

        [InverseProperty("FacebookUser")]
		#endregion PostShares Annotations

        public virtual ICollection<PostShare> PostShares { get; set; }

		#region ProfilePhotos Annotations

        [InverseProperty("FacebookUser")]
		#endregion ProfilePhotos Annotations

        public virtual ICollection<ProfilePhoto> ProfilePhotos { get; set; }

		#region FacebookUserDetails Annotations

        [InverseProperty("FacebookUser")]
		#endregion FacebookUserDetails Annotations

        public virtual ICollection<FacebookUserDetail> FacebookUserDetails { get; set; }

		#region FacebookUserWorks Annotations

        [InverseProperty("FacebookUser")]
		#endregion FacebookUserWorks Annotations

        public virtual ICollection<FacebookUserWork> FacebookUserWorks { get; set; }


        public FacebookUser()
        {
			Posts = new HashSet<Post>();
			PostMessages = new HashSet<PostMessage>();
			ChatMedia = new HashSet<ChatMedia>();
			ChatMedia1 = new HashSet<ChatMedia>();
			ChatMessages = new HashSet<ChatMessage>();
			ChatMessages1 = new HashSet<ChatMessage>();
			CoverPhotos = new HashSet<CoverPhoto>();
			EducationDetails = new HashSet<EducationDetail>();
			LogActivities = new HashSet<LogActivity>();
			PostComments = new HashSet<PostComment>();
			PostLikes = new HashSet<PostLike>();
			PostShares = new HashSet<PostShare>();
			ProfilePhotos = new HashSet<ProfilePhoto>();
			FacebookUserDetails = new HashSet<FacebookUserDetail>();
			FacebookUserWorks = new HashSet<FacebookUserWork>();
        }
	}
}