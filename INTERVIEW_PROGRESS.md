# Coding Interview Progress

## Classification

- **Group A:** Could not solve independently or required major assistance.
- **Group B:** Solved with meaningful hints, heavy struggle, or excessive time.
- **Group C:** Solved mostly independently with sound reasoning and implementation.
- **Mastered:** Solved again after a meaningful delay without relying on memorized code.

## Problem Log

| Problem | Difficulty | Attempt date | Topic/pattern (after attempt) | Independence / highest hint | Time | Complexity analysis | Key insight or mistake | Status | Repeat |
|---|---|---|---|---|---:|---|---|---|---|
| 121. Best Time to Buy and Sell Stock | Easy | 2026-08-18; review 2026-08-21 | One-pass scan; running minimum; running optimum | Initial Level 4; review independent with minor compile correction | Not recorded | Review correctly derived O(n) time and O(1) space independently | Repeatedly searching earlier prices can be replaced by the lowest price seen so far. Review exposed only an uninitialized maximum-profit variable. | Group C | 2026-09-04 |
| 217. Contains Duplicate | Easy | 2026-08-19 | Hash set; membership tracking | Meaningful guided help / Level 3 | Not recorded | Final expected O(n) time and O(n) space correct; initially misanalyzed pairwise and sorting costs | A set of previously seen values replaces repeated pairwise comparisons. Distinguish values from hashes; remember to initialize collections and check C# delimiters. | Group B | 2026-08-24 |
| 242. Valid Anagram | Easy | 2026-08-19 | Frequency counting; hash map | Mostly independent / Level 1 plus C# API help | Not recorded | Correctly derived O(n) expected time and O(1) space for the fixed 26-letter alphabet | A frequency map can summarize multiplicities; increment for one string and decrement/remove for the other. Use `Length` for strings and practice dictionary syntax. | Group C | 2026-09-02 |
| 1. Two Sum | Easy | 2026-08-20 | Complement lookup; hash map from value to index | Meaningful guided help / Level 3 plus C# API help | Not recorded | Correctly derived O(n) expected time and O(n) space | Store previously seen number → index, check the complement before storing, and keep dictionary keys and values conceptually distinct. | Group B | 2026-08-26 |
| 125. Valid Palindrome | Easy | 2026-08-22 | Opposite-direction two pointers; filtered comparison | Meaningful guided help / Level 4 plus C# API help | Not recorded | Initially misstated; correctly derived O(n) time and O(1) space after guidance | Compare valid characters in place while skipping non-alphanumeric input. Use `char.IsLetterOrDigit`, normalize each compared character, and stop when pointers meet or cross. | Group B | 2026-08-29 |

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
