# Collections Answers

 What is IReadOnlyDictionary<TKey, TValue>?

It is an interface that allows reading key-value pairs without exposing methods to add, update, or remove entries.


 How is it different from Dictionary and why return it from a public method?

Dictionary allows modifying entries while IReadOnlyDictionary exposes read-only operations. Returning the interface limits the operations available to callers and makes the API more flexible.

 How is SortedDictionary<TKey, TValue> different from Dictionary?

SortedDictionary automatically sorts entries by key and provides O(log n) lookup, while Dictionary does not guarantee sorted order and provides average O(1) lookup.

 When would you choose SortedDictionary?

I would choose it when I need keys to remain sorted while frequently adding, removing, and searching for entries.


===================================================================================================

- S1 — Dictionary: Fast lookup of students by national ID using key-value pairs.
- S2 — HashSet: Stores unique tags and prevents duplicates.
- S3 — List: Preserves the order of grades and allows duplicates.
- S4 — IReadOnlyDictionary: Allows callers to read prices without modifying them through the interface.
- S5 — SortedDictionary: Keeps sessions sorted by their start time as new sessions are added.
- S6 — IEnumerable: Allows the caller to iterate once and stop early without requiring all results at once.


