# Part 03 — answers

---

## BlockedUsers

- Time complexity before: O(n+m+mn)
- Time (ms) before: 10ms
- What did you change? Changed the data structure from a List to a HashSet 
- Time complexity after: O(n+m)
- Time (ms) after: 0ms

---

## Students

- What was the problem? 
- the GetAllStudents method was returning a list of students at once , which could be a large number of students and could cause performance issues .
- What did you change?
- i changed the method to return an IEnumerable of students instead of a list and used yield return to return the students one at a time, which allows the caller to process the students as they are returned instead of waiting for the entire list to be returned.
