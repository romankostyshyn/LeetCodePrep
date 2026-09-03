# Coding Interview Progress

## Classification

- **Group A:** Could not solve independently or required major assistance.
- **Group B:** Solved with meaningful hints, heavy struggle, or excessive time.
- **Group C:** Solved mostly independently with sound reasoning and implementation.
- **Mastered:** Solved again after a meaningful delay without relying on memorized code.

## Problem Log

| Problem | Difficulty | Attempt date | Topic/pattern (after attempt) | Independence / highest hint | Time | Complexity analysis | Key insight or mistake | Status | Repeat |
|---|---|---|---|---|---:|---|---|---|---|
| 121. Best Time to Buy and Sell Stock | Easy | 2026-08-18; review 2026-08-21 | One-pass scan; running minimum; running optimum | Initial Level 4; review independent with minor compile correction | Not recorded | Review correctly derived O(n) time and O(1) space independently | Repeatedly searching earlier prices can be replaced by the lowest price seen so far. Review exposed only an uninitialized maximum-profit variable. | Group C | 2026-09-06 (rescheduled from 2026-09-04) |
| 217. Contains Duplicate | Easy | 2026-08-19; review 2026-08-24 | Hash set; membership tracking | Initial Level 3; review independent | Not recorded | Review correctly derived expected O(n) time and O(n) space independently | `HashSet.Add` combines insertion and duplicate detection. Be precise about the return value versus the negated `if` condition. | Group C | 2026-09-07 |
| 242. Valid Anagram | Easy | 2026-08-19 | Frequency counting; hash map | Mostly independent / Level 1 plus C# API help | Not recorded | Correctly derived O(n) expected time and O(1) space for the fixed 26-letter alphabet | A frequency map can summarize multiplicities; increment for one string and decrement/remove for the other. Use `Length` for strings and practice dictionary syntax. | Group C | 2026-09-05 (rescheduled from 2026-09-02) |
| 1. Two Sum | Easy | 2026-08-20; review 2026-08-26 | Complement lookup; hash map from value to index | Initial Level 3; review algorithm independent with C# API corrections | Not recorded | Review correctly derived expected O(n) time and O(n) space independently | Store previously seen number → index and check before storing. Continue practicing `TryGetValue(..., out value)` and indexer assignment `[key] = value`. | Group C | 2026-09-09 |
| 125. Valid Palindrome | Easy | 2026-08-22; review 2026-08-31 | Opposite-direction two pointers; filtered comparison | Initial Level 4; delayed review fully independent | Not recorded | Delayed review independently derived and implemented O(n) time and O(1) space | Compare valid characters in place while skipping non-alphanumeric input. Clean delayed retrieval included correct C# APIs and edge-case dry runs. | Mastered | 2026-10-05 maintenance review |
| 977. Squares of a Sorted Array | Easy | 2026-08-23; review 2026-09-03 | Opposite-direction two pointers; fill output backward | Initial Level 4; review independent with one loop-condition correction | Not recorded | Review correctly derived O(n) time, O(n) output space, and O(1) auxiliary space | In sorted input, the largest remaining absolute value is at an endpoint. Place its square at the back and move only that endpoint. | Group C | 2026-09-17 |
| 283. Move Zeroes | Easy | 2026-08-24 | Same-direction read/write pointers; stable in-place compaction | Meaningful guided help / Level 4 | Not recorded | Correctly derived O(n) time and O(1) auxiliary space | Compact non-zero values in original order, then fill the remaining suffix with zeroes. The write pointer never passes the scan pointer. | Group B | 2026-09-04 (rescheduled from 2026-09-02) |
| 392. Is Subsequence | Easy | 2026-08-31 | Same-direction two pointers; ordered matching | Algorithm derived independently; meaningful implementation debugging | Not recorded | Correctly derived O(m) time, where m is `t.Length`, and O(1) space | Advance through `t` every iteration and through `s` only on a match. Guard both indices and ensure dry runs reflect unconditional pointer movement. | Group B | 2026-09-08 |
| 643. Maximum Average Subarray I | Easy | 2026-09-03 | Fixed-size sliding window; rolling sum | Meaningful guided help / Level 4 | Not recorded | Correctly derived O(n) time and O(1) auxiliary space after guidance | Build the first window once, then subtract the leaving value and add the entering value. Keep current state separate from the best state and cast before division. | Group B | 2026-09-11 |

## Review Queue

Review timing will be assigned after each attempt. Group A and Group B problems return sooner; Group C problems return later and must be solved again before becoming Mastered.

## Session Notes

### Day 1 — 2026-08-18

- Planned: 121. Best Time to Buy and Sell Stock; 217. Contains Duplicate; optional 242. Valid Anagram depending on the depth and duration of the first two.
- Completed: 121. Best Time to Buy and Sell Stock — Group B; repeat scheduled for 2026-08-21.
- Completed post-problem pattern reflection.
- Session ended after one in-depth problem; 217. Contains Duplicate deferred to Day 2.

### Day 2 — 2026-08-19

- Completed: 217. Contains Duplicate — Group B; repeat scheduled for 2026-08-24.
- Completed: 242. Valid Anagram — Group C; repeat scheduled for 2026-09-02.
- Completed post-problem reflection and introduced fixed-size frequency arrays for bounded alphabets.
- Day 2 complete after two problems.

### Day 3 — 2026-08-20

- Follow-up: implemented the fixed-size `int[26]` alternative for 242. Valid Anagram.
- Key reinforcement: map lowercase characters with `character - 'a'`; prefer narrow local-variable scope.
- Completed: 1. Two Sum — Group B; repeat scheduled for 2026-08-26.
- Completed post-problem reflection.
- Day 3 complete; 125. Valid Palindrome was introduced but not attempted.
- Day 4 should begin with the scheduled fresh review of 121. Best Time to Buy and Sell Stock, then continue with 125 if time permits.

### Day 4 — 2026-08-21

- Completed delayed review: 121. Best Time to Buy and Sell Stock — promoted from Group B to Group C; next review scheduled for 2026-09-04.
- One focused late-evening problem; 125. Valid Palindrome remains unattempted.

### Day 5 — 2026-08-22

- Completed: 125. Valid Palindrome — Group B; repeat scheduled for 2026-08-29.
- Introduced opposite-direction two pointers and in-place filtered comparison.
- Completed post-problem reflection.
- Day 5 complete; 977. Squares of a Sorted Array deferred to Day 6.

### Day 6 — 2026-08-23

- Completed: 977. Squares of a Sorted Array — Group B; repeat scheduled for 2026-08-30.
- Reinforced opposite-direction pointers, backward output construction, and output-versus-auxiliary space.
- Completed post-problem reflection.
- Day 6 complete; 283. Move Zeroes was introduced but not attempted.
- Day 7 should begin with the scheduled fresh review of 217. Contains Duplicate, then continue with 283 if time permits.

### Day 7 — 2026-08-24

- Completed delayed review: 217. Contains Duplicate — promoted from Group B to Group C; next review scheduled for 2026-09-07.
- Completed: 283. Move Zeroes — Group B; repeat scheduled for 2026-08-31.
- Introduced same-direction read/write pointers and stable in-place compaction.
- Completed post-problem reflection; clarified the read/write invariant before versus after processing an index.
- Day 7 complete after one review and one new problem.

### Day 8 — 2026-08-26

- Completed delayed review: 1. Two Sum — promoted from Group B to Group C; next review scheduled for 2026-09-09.
- Short busy-day session focused on one review problem.

### Day 9 — 2026-08-31

- Returned after several days away; review queue staggered to avoid cramming.
- Plan: 125 review today, 977 review on 2026-09-01, and 283 review on 2026-09-02; resume new problems as session depth permits.
- Completed delayed review: 125. Valid Palindrome — promoted from Group B to Mastered; maintenance review scheduled for 2026-10-05.
- Completed: 392. Is Subsequence — Group B; repeat scheduled for 2026-09-08.

### Day 10 — 2026-09-03

- Returned after two missed days; overdue reviews staggered again rather than crammed.
- Completed delayed review: 977. Squares of a Sorted Array — promoted from Group B to Group C; next review scheduled for 2026-09-17.
- Completed: 643. Maximum Average Subarray I — Group B; repeat scheduled for 2026-09-11.
- Introduced fixed-size sliding windows and rolling sums.
- Completed post-problem reflection.
- Day 10 complete after one delayed review and one new problem.

### Day 10 — 2026-09-03

- Returned after two missed days; overdue reviews staggered to protect retrieval quality.
- Plan: 977 review today, 283 review on 2026-09-04, 242 review on 2026-09-05, and 121 review on 2026-09-06; add new material only as session depth permits.
