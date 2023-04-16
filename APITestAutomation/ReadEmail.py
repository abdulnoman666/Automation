# Python 3.8.0
import re
import smtplib
import time
import imaplib
import email
import traceback

# -------------------------------------------------
#
# Utility to read email from Gmail Using Python
#
# ------------------------------------------------
ORG_EMAIL = "@finboa.com"
FROM_EMAIL = "abdul" + ORG_EMAIL
FROM_PWD = "$Pak35tan$2026"
SMTP_SERVER = "imap.gmail.com"
SMTP_PORT = 993


def read_email_from_gmail():
    try:
        mail = imaplib.IMAP4_SSL(SMTP_SERVER)
        mail.login(FROM_EMAIL, FROM_PWD)
        mail.select('inbox')

        data = mail.search(None, 'ALL')
        mail_ids = data[1]
        id_list = mail_ids[0].split()
        first_email_id = int(id_list[0])
        latest_email_id = int(id_list[-1])

        data = mail.fetch(str(latest_email_id), '(RFC822)')
        for response_part in data:
            arr = response_part[0]
            if isinstance(arr, tuple):
                msg = email.message_from_string(str(arr[1], 'utf-8'))
                #email_subject = msg['subject']
                #email_from = msg['from']
                #email_to = msg['to']
                #entity_id = msg['X-Entity-ID']
                #print('From : ' + email_from + '\n')
                #print('Subject : ' + email_subject + '\n')
                #print('Email To : ' + email_to + '\n')
                #print('X-Entity-ID : ' + entity_id + '\n')
                #print(type(msg.message.Message)
                msg = str(msg)
                p = re.compile("Your Login Authentication Code is: (.*)")
                result = p.search(msg)
                print(result[1])

    except Exception as e:
        traceback.print_exc()
        print(str(e))


read_email_from_gmail()
