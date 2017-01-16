using PrtgSharp.Utilities;

namespace PrtgSharp.ChannelProperties.Optional.FirstRun
{
    /// <summary>
    /// Define an additional message. It will be added to the sensor's message when entering a "Warning" status that is triggered by a limit. Note: The values defined with this element will be considered only on the first sensor scan, when the channel is newly created; they are ignored on all further sensor scans (and may be omitted). You can change this initial setting later in the Channel settings of the sensor.
    /// </summary>
    public class LimitWarningMessageOnFirstRunProperty : ChannelProperty
    {
        public LimitWarningMessageOnFirstRunProperty(string warningMessage)
            : base("limitwarningmsg", warningMessage.TruncateWithEllipsis(256)) { }
    }
}