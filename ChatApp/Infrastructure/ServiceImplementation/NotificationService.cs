using ChatApp.Business.ServiceInterfaces;
using ChatApp.Models.NotificationModel;

namespace ChatApp.Infrastructure.ServiceImplementation
{
    public class NotificationService : INotificationService
    {
        public void addToGroup(List<int> selUserIds, int userId, int groupId)
        {
            throw new NotImplementedException();
        }

        public void adminNoti(int userId, int loginUserId, int groupId)
        {
            throw new NotImplementedException();
        }

        public void Clear(string userName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NotificationModel> GetAllNotifications(string userName)
        {
            throw new NotImplementedException();
        }

        public void groupMsgNoti(int loginUserId, int groupId, string? msgtype)
        {
            throw new NotImplementedException();
        }

        public void removeNoti(int selUserId, int userId, int groupId)
        {
            throw new NotImplementedException();
        }
    }
}
