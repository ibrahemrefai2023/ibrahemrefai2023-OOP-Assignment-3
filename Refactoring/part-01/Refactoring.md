# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
- The Calculate method in ShippingCostCalculator used a switch statement to determine the carrier which made it difficult to add new carriers without modifying the existing code.
- What did you change?
- I refactored the ShippingCostCalculator class to use a strategy pattern I created an interface for carriers and implemented separate classes for each carrier This allows for easy addition of new carriers without modifying the existing code.

---

## OrderProcessor

- What was the problem?
- The OrderProcessor class was tightly coupled with the ShippingCostCalculator and Notifications classes making it difficult to add new notification channels without modifying the existing code.
- What did you change?
- I refactored the OrderProcessor class to use dependency injection for the ShippingCostCalculator and Notifications classes. This allows for easy addition of new notification channels without modifying the existing code and remove tightly coupled.

---

## Notifications

- What was the problem?
- The Notifications class was tightly coupled with the many classes.
- What did you change?
- I refactored the Notifications class to use a strategy pattern I created an interface for notification channels and implemented separate classes for each notification channel. This allows for easy addition of new notification channels without modifying the existing code.

---

## Proof

- New carrier file(s):
- New notification channel file(s):
- Existing classes left unchanged? (yes/no): no
