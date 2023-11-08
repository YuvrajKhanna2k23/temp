using ChatApp.Models.NotificationModel;

namespace ChatApp.Business.ServiceInterfaces
{
    public interface INotificationService
    {
        public IEnumerable<NotificationModel> GetAllNotifications(string userName);

        public void addToGroup(List<int> selUserIds, int userId, int groupId);
        public void adminNoti(int userId, int loginUserId, int groupId);
        public void removeNoti(int selUserId, int userId, int groupId);
        public void groupMsgNoti(int loginUserId, int groupId, string? msgtype);
        public void Clear(string userName);
    }
}
