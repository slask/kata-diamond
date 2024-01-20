# The Diamond Kata

Given a character from the alphabet, print a diamond of its output with that character being the midpoint of the diamond.

Examples

    > diamond.exe A
      A

    > diamond.exe B
       A
      B B
       A

    > diamond.exe C
        A
       B B
      C   C
       B B
        A

## Hints

It may be helpful visualize the whitespace in your rendering like this:

    > diamond.exe C
    _ _ A _ _
    _ B _ B _
    C _ _ _ C
    _ B _ B _
    _ _ A _ _

    _ _ _ A _ _ _
    _ _ B _ B _ _
    _ C _ _ _ C _
    D _ _ _ _ _ D
    _ C _ _ _ C _
    _ _ B _ B _ _
    _ _ _ A _ _ _