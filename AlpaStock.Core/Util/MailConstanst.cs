namespace AlpaStock.Core.Util
{
    public static class MailConstants
    {
        public const string ClientEnquiryAcknowledgement = @"
<html>
  <body style='font-family: Arial, sans-serif; background-color: #f8f9fa; margin: 0; padding: 0;'>
    <div style='max-width: 600px; margin: 40px auto; background-color: #ffffff; padding: 30px; border-radius: 8px; box-shadow: 0 2px 6px rgba(0,0,0,0.1);'>
      <h2 style='color: #351F05;'>Thank You for Contacting Us</h2>
      <p style='color: #555;'>Hi {{FullName}},</p>
      <p style='color: #555;'>We’ve received your enquiry and our team will get back to you shortly.</p>
      <p style='color: #555;'><strong>Your Message:</strong></p>
      <p style='color: #555;'>{{Message}}</p>
      <p style='color: #555;'>We appreciate your interest.</p>
      <div style='margin-top: 30px; font-size: 12px; color: #999;'>
        &copy; {{Year}} Alpha Strategy. All rights reserved.
      </div>
    </div>
  </body>
</html>";

        public const string AdminNewEnquiryNotification = @"
<html>
  <body style='font-family: Arial, sans-serif; background-color: #f8f9fa; margin: 0; padding: 0;'>
    <div style='max-width: 600px; margin: 40px auto; background-color: #ffffff; padding: 30px; border-radius: 8px; box-shadow: 0 2px 6px rgba(0,0,0,0.1);'>
      <h2 style='color: #351F05;'>New Enquiry Notification</h2>
      <p style='color: #333; line-height: 1.6;'><strong>From:</strong> {{FullName}} &lt;{{Email}}&gt;</p>
      <p style='color: #333; line-height: 1.6;'><strong>Phone:</strong> {{Phone}}</p>
      <p style='color: #333; line-height: 1.6;'><strong>Message:</strong></p>
      <div style='background: #f4f4f4; padding: 10px; border-radius: 6px; margin-top: 10px; color: #333;'>
        {{Message}}
      </div>
      <p style='color: #333; line-height: 1.6;'>Please follow up with the client as soon as possible.</p>
    </div>
  </body>
</html>";
    }


}
