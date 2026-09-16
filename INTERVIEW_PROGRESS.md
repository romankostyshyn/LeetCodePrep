# Coding Interview Progress

## Classification

- **Group A:** Could not solve independently or required major assistance.
- **Group B:** Solved with meaningful hints, heavy struggle, or excessive time.
- **Group C:** Solved mostly independently with sound reasoning and implementation.
- **Mastered:** Solved again after a meaningful delay without relying on memorized code.

## Problem Log

| Problem | Difficulty | Attempt date | Topic/pattern (after attempt) | Independence / highest hint | Time | Complexity analysis | Key insight or mistake | Status | Repeat |
|---|---|---|---|---|---:|---|---|---|---|
| 121. Best Time to Buy and Sell Stock | Easy | 2026-08-18; reviews 2026-08-21 and 2026-09-06 | One-pass scan; running minimum; running optimum | Initial Level 4; first review independent with minor compile correction; delayed review fully independent | Not recorded | Delayed review cleanly derived O(n) time and O(1) space, implemented the solution, and justified the invariant | For each selling day, the smallest earlier price gives the greatest possible profit. Maintain that running minimum and the best profit seen so far. | Mastered | 2026-10-11 maintenance review |
| 217. Contains Duplicate | Easy | 2026-08-19; reviews 2026-08-24 and 2026-09-08 | Hash set; membership tracking | Initial Level 3; first review independent; delayed review fully independent | Not recorded | Delayed review cleanly derived expected O(n) time and O(n) space, implemented the solution, and completed a correct dry run | `HashSet.Add` combines insertion and duplicate detection: a false result proves the value was already present. Return false only after every element has been examined. | Mastered | 2026-10-13 maintenance review |
| 242. Valid Anagram | Easy | 2026-08-19; review 2026-09-06 | Frequency counting; fixed-size frequency array | Initial mostly independent / Level 1 plus C# API help; review recovered frequency counting independently with minor corrections | Not recorded | Review correctly derived O(n) time and O(1) space for the fixed 26-letter alphabet | Map each lowercase letter with `character - 'a'`; increment from one string and decrement from the other. Review needed corrections to compare lengths rather than strings and to use the computed array index consistently. | Group C | 2026-09-20 |
| 1. Two Sum | Easy | 2026-08-20; reviews 2026-08-26 and 2026-09-09 | Complement lookup; hash map from value to index | Initial Level 3; reviews recovered algorithm independently with minor C# and explanation corrections | Not recorded | Latest review correctly derived expected O(n) time and O(n) space and implemented complement lookup before insertion | Store previously seen number → index and check before storing so the same index cannot be reused. Indexer assignment safely replaces the stored index for a duplicate key; the fallback used an invalid .NET exception type. | Group C | 2026-09-24 |
| 125. Valid Palindrome | Easy | 2026-08-22; review 2026-08-31 | Opposite-direction two pointers; filtered comparison | Initial Level 4; delayed review fully independent | Not recorded | Delayed review independently derived and implemented O(n) time and O(1) space | Compare valid characters in place while skipping non-alphanumeric input. Clean delayed retrieval included correct C# APIs and edge-case dry runs. | Mastered | 2026-10-05 maintenance review |
| 977. Squares of a Sorted Array | Easy | 2026-08-23; review 2026-09-03 | Opposite-direction two pointers; fill output backward | Initial Level 4; review independent with one loop-condition correction | Not recorded | Review correctly derived O(n) time, O(n) output space, and O(1) auxiliary space | In sorted input, the largest remaining absolute value is at an endpoint. Place its square at the back and move only that endpoint. | Group C | 2026-09-17 |
| 283. Move Zeroes | Easy | 2026-08-24; review 2026-09-04 | Same-direction read/write pointers; stable in-place compaction | Initial Level 4; review independent with interface correction | Not recorded | Review correctly derived O(n) time and O(1) auxiliary space | Compact non-zero values in original order, then fill the remaining suffix with zeroes. Distinguish in-place mutation from the method's required return type. | Group C | 2026-09-18 |
| 392. Is Subsequence | Easy | 2026-08-31; review 2026-09-08–2026-09-09 | Same-direction two pointers; ordered matching | Initial algorithm independent with meaningful implementation debugging; review algorithm independent with loop-bound correction | Not recorded | Review correctly derived O(m) time, where m is `t.Length`, and O(1) space, then completed a correct dry run and greedy justification | Advance through `t` every iteration and through `s` only on a match. Guard both indices with strict bounds; choosing the earliest match leaves the largest suffix available for later matches. | Group C | 2026-09-23 |
| 643. Maximum Average Subarray I | Easy | 2026-09-03; review 2026-09-15 | Fixed-size sliding window; rolling sum | Initial Level 4; review recovered the algorithm independently but needed Level 3 implementation debugging | Not recorded | Review correctly derived O(n) time and O(1) auxiliary space after correcting the rolling-state implementation | The next window must be derived from `currentSum`, not `maxSum`; the review repeated this state bug and needed the failing case `[5,-100,4,4]`. Cast before division and keep current state separate from historical optimum. | Group B | 2026-09-21 |
| 219. Contains Duplicate II | Easy | 2026-09-04; review 2026-09-16 | Most-recent-index tracking; hash map | Initial Level 3 plus C# API corrections; delayed review independent with minor precision prompting | Not recorded | Review independently derived expected O(n) time and O(n) space, produced correct code, and verified the most-recent-index invariant | Map each value to its most recent index. For any future occurrence, the most recent prior index gives the smallest distance; a duplicate outside the limit must update the index rather than cause an early false result. | Group C | 2026-09-30 |
| 20. Valid Parentheses | Easy | 2026-09-10; review 2026-09-16 | Stack; delimiter matching | Initial Level 3 structural hint; review recovered the pattern independently but needed Level 3 control-flow debugging | Not recorded | Review correctly derived O(n) time and O(n) space and completed an accurate dry run after implementation corrections | Push expected closing brackets and require every closer to match the top. The review omitted the empty-stack guard, initially ignored mismatches, and then made the mismatch return unconditional before correcting both branches. | Group B | 2026-09-22 |

## Review Queue

Review timing will be assigned after each attempt. Group A and Group B problems return sooner; Group C problems return later and must be solved again before becoming Mastered.

At the start of every session, verify the current Europe/Warsaw date and adjust overdue or upcoming reviews before choosing the day's work.

If a session crosses midnight without the user ending the learning day, keep recording work under that learning day's original date; begin the new date only after the user ends and later resumes.

Before creating or changing a problem assessment, review the entire exchange for that problem from restatement through final verification. Distinguish insights produced by the user from patterns, data structures, or implementation steps supplied by the interviewer.

Record the highest hint actually given, all material reasoning and implementation corrections, the quality of dry runs and correctness explanations, and only then assign the group and next review date. When independence is uncertain, use the more conservative assessment.

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
- Plan: 977 review today, 283 review on 2026-09-04, 242 review on 2026-09-05, and 121 review on 2026-09-06; add new material only as session depth permits.
- Completed delayed review: 977. Squares of a Sorted Array — promoted from Group B to Group C; next review scheduled for 2026-09-17.
- Completed: 643. Maximum Average Subarray I — Group B; repeat scheduled for 2026-09-11.
- Introduced fixed-size sliding windows and rolling sums.
- Completed post-problem reflection.
- Day 10 complete after one delayed review and one new problem.

### Day 11 — 2026-09-04

- Completed the scheduled review: 283. Move Zeroes — promoted from Group B to Group C; next review scheduled for 2026-09-18.
- Completed: 219. Contains Duplicate II — Group B; repeat scheduled for 2026-09-12.
- Calendar date crossed midnight during the session; progress remains under the user-defined Day 11 date of 2026-09-04.

### Day 12 — 2026-09-06

- Plan: complete the overdue review of 242. Valid Anagram, then review 121. Best Time to Buy and Sell Stock if the first review remains focused; no new problem is required today.
- Completed delayed review: 242. Valid Anagram — remains Group C; next review scheduled for 2026-09-20.
- Review result: independently recovered frequency counting and complexity, then implemented the fixed `int[26]` approach after a prompt; corrected a length-check error and an inconsistent array-index variable.
- Completed delayed review: 121. Best Time to Buy and Sell Stock — promoted from Group C to Mastered; maintenance review scheduled for 2026-10-11.
- Review result: independently restated the problem, derived brute-force and optimized approaches, wrote correct code, completed a precise dry run, and justified why the running minimum is sufficient.
- Day 12 complete after two delayed reviews.

### Day 13 — 2026-09-08

- Returned after missing the 2026-09-07 session; review queue adjusted without moving later reviews unnecessarily.
- Plan: begin with the overdue review of 217. Contains Duplicate, then complete the scheduled review of 392. Is Subsequence. Add a new problem only if both reviews are clean and focused.
- Upcoming queue remains: 1. Two Sum on 2026-09-09, 643. Maximum Average Subarray I on 2026-09-11, and 219. Contains Duplicate II on 2026-09-12.
- Completed delayed review: 217. Contains Duplicate — promoted from Group C to Mastered; maintenance review scheduled for 2026-10-13.
- Review result: independently derived brute-force and hash-set approaches, wrote the concise `HashSet.Add` implementation, and justified the final false return.
- Began the delayed review of 392. Is Subsequence: independently restated the problem, supplied examples, and recovered the optimal O(m)-time, O(1)-space scan; C# implementation and verification deferred to the next learning session.
- Day 13 ended after one completed review and one partial review.

### Day 14 — 2026-09-09

- Plan: resume 392. Is Subsequence directly with C# implementation, dry run, and correctness explanation.
- Review 1. Two Sum afterward only if time remains; otherwise move it to 2026-09-10. Keep 643. Maximum Average Subarray I on 2026-09-11 and 219. Contains Duplicate II on 2026-09-12.
- Completed delayed review: 392. Is Subsequence — promoted from Group B to Group C; next review scheduled for 2026-09-23.
- Review result: independently recovered the greedy scan and complexities; corrected an inclusive loop bound that could access `t[t.Length]`, then completed a correct dry run and justification.
- Completed delayed review: 1. Two Sum — remains Group C; next review scheduled for 2026-09-24.
- Review result: independently recovered brute-force and complement-map approaches and wrote the core implementation; corrected the fallback exception type and clarified duplicate-key overwriting and lookup-before-insert behavior.
- Day 14 complete after finishing two delayed reviews.
- Next-session plan for 2026-09-10: introduce 20. Valid Parentheses as a new foundational problem, using the full interview workflow; reveal and discuss its pattern only after the attempt. Keep the scheduled 643 review on 2026-09-11.

### Day 15 — 2026-09-10

- Plan: fresh attempt of 20. Valid Parentheses using the full interview workflow; do not reveal the intended pattern before the user's approach.
- Keep the scheduled review of 643. Maximum Average Subarray I on 2026-09-11.
- Completed: 20. Valid Parentheses — Group B; first review scheduled for 2026-09-16.
- Result: independently identified the need to remember unmatched opening brackets, then received the stack/LIFO structural hint; afterward independently chose to store expected closing brackets, wrote correct C# code, and explained the behavior accurately.
- Progress correction: the initial entry incorrectly credited the stack discovery as independent; corrected after reviewing the conversation sequence.

### Day 16 — 2026-09-15

- Returned after missing several sessions; overdue reviews rescheduled without adding new material.
- Plan: review 643. Maximum Average Subarray I first, then review 219. Contains Duplicate II if the first review remains focused. If 219 is not completed, move it to 2026-09-19.
- Keep upcoming reviews: 20. Valid Parentheses on 2026-09-16, 977. Squares of a Sorted Array on 2026-09-17, and 283. Move Zeroes on 2026-09-18.
- Completed delayed review: 643. Maximum Average Subarray I — remains Group B; next review scheduled for 2026-09-21.
- Review audit: independently recovered the fixed-window optimization and final complexities, but repeated the `maxSum` versus `currentSum` bug and needed a failing test plus explicit state-separation guidance before producing correct code and dry run.
- Deferred the overdue review of 219. Contains Duplicate II to 2026-09-16 at the user's request; it will share the session with the scheduled review of 20. Valid Parentheses.
- Day 16 complete after one focused delayed review.

### Day 17 — 2026-09-16

- Plan: complete the overdue review of 219. Contains Duplicate II first, then complete the first review of 20. Valid Parentheses. No new problem today.
- If only one review fits, prioritize 219 and move 20 to 2026-09-19; keep 977. Squares of a Sorted Array on 2026-09-17 and 283. Move Zeroes on 2026-09-18.
- Completed delayed review: 219. Contains Duplicate II — promoted from Group B to Group C; next review scheduled for 2026-09-30.
- Review audit: independently recovered the dictionary from value to most recent index, justified replacing stale indices, wrote correct C#, and completed an accurate dry run and complexity analysis; guidance was limited to precision about absolute distance and proof prompts.
- Completed review: 20. Valid Parentheses — remains Group B; next review scheduled for 2026-09-22.
- Review audit: independently recovered the stack and expected-closing-bracket design, but needed an empty-stack reminder and two rounds of control-flow debugging for mismatched closers before producing correct code and verification.
- Day 17 complete after two reviews; no new problem added.
