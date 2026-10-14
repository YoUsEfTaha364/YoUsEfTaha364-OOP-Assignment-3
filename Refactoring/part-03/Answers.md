# Part 03 — answers

---

## BlockedUsers

- Time complexity before:
    o(n^2)
- Time (ms) before:
   25 ms
- What did you change?
   use HashSet to make serach o(1)
- Time complexity after:
   o(n)
- Time (ms) after:
  2 ms

---

## Students

- What was the problem?
  GetAllStudents()  executed first and make a big list of 1000000 items and i need only first 3 

- What did you change?

 i have used the yield keyword to make lazy generation 
