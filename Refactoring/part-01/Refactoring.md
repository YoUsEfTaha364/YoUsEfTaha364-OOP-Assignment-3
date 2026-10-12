# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?

  the problem was if another calculation add i must change the file and add if else 

- What did you change?

  make strategy pattern that uses the strategy directly

---
## OrderProcessor

- What was the problem?
 
   any chnage in the other classes must change in the Order class so i must make it as interface any change does not lead to OrderProcess class 
- What did you change?

so i must make it as interface any change does not lead to OrderProcess class

---

## Notifications

- What was the problem?

The original design used inheritance to represent different combinations of notification behaviors, such as email, SMS, urgency, and scheduling.

- What did you change?

Notification channel: Responsible for delivering the message, such as email, SMS, or the new channel.

Message formatter: Responsible for formatting the message, including adding the [URGENT] prefix.

Scheduler: Responsible for determining when the notification is executed.


---

## Proof

New carrier file(s): WhatsAppCarrier.cs (replace with the actual filename).

New notification channel file(s): NewNotificationChannel.cs (replace with the actual filename).

Existing classes left unchanged? (yes/no): Yes, except Program.cs, which was updated to wire in and demonstrate the new implementations.