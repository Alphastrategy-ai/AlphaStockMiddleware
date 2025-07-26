using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlpaStock.Core.Util
{
    public static class MailConstanst
    {
        public const string ClientEnquiryAcknowledgement = @"
    <html>
      <head>
        <style>
          body {{
            font-family: Arial, sans-serif;
            background-color: #f8f9fa;
            margin: 0;
            padding: 0;
          }}
          .container {{
            max-width: 600px;
            margin: 40px auto;
            background-color: #fff;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 2px 6px rgba(0,0,0,0.1);
          }}
          h2 {{
            color: #2c3e50;
          }}
          p {{
            color: #555;
          }}
          .footer {{
            margin-top: 30px;
            font-size: 12px;
            color: #999;
          }}
        </style>
      </head>
      <body>
        <div class='container'>
          <h2>Thank You for Contacting Us</h2>
          <p>Hi {{FullName}},</p>
          <p>We’ve received your enquiry and our team will get back to you shortly.</p>
          <p><strong>Your Message:</strong></p>
          <p>{{Message}}</p>
          <p>We appreciate your interest.</p>
          <div class='footer'>
            &copy; {{Year}} Apha Strategy. All rights reserved.
          </div>
        </div>
      </body>
    </html>";

        public const string AdminNewEnquiryNotification = @"
    <html>
      <head>
        <style>
          body {{
            font-family: Arial, sans-serif;
            background-color: #f8f9fa;
            margin: 0;
            padding: 0;
          }}
          .container {{
            max-width: 600px;
            margin: 40px auto;
            background-color: #fff;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 2px 6px rgba(0,0,0,0.1);
          }}
          h2 {{
            color: #2c3e50;
          }}
          p {{
            color: #333;
            line-height: 1.6;
          }}
          .detail {{
            background: #f4f4f4;
            padding: 10px;
            border-radius: 6px;
            margin-top: 10px;
          }}
        </style>
      </head>
      <body>
        <div class='container'>
          <h2>New Enquiry Notification</h2>
          <p><strong>From:</strong> {{FullName}} &lt;{{Email}}&gt;</p>
          <p><strong>Phone:</strong> {{Phone}}</p>
          <p><strong>Message:</strong></p>
          <div class='detail'>
            {{Message}}
          </div>
          <p>Please follow up with the client as soon as possible.</p>
        </div>
      </body>
    </html>";
    }
}
