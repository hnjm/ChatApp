namespace ChatApp.Domain.Enums;

/// <summary>
/// نوع المحادثة - Conversation Type
/// </summary>
public enum ConversationType
{
    /// <summary>محادثة فردية - Peer to Peer</summary>
    PeerToPeer = 0,
    
    /// <summary>مجموعة - Group</summary>
    Group = 1,
    
    /// <summary>قناة - Channel</summary>
    Channel = 2
}
