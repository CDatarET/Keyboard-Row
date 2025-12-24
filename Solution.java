class Solution {
    public String[] findWords(String[] words) {
        String r1 = "qwertyuiop";
        String r2 = "asdfghjkl";
        String r3 = "zxcvbnm";

        List<String> ret = new ArrayList<>();

        for (String s : words) {
            int row = 0;
            boolean inv = false;

            for (char c : s.toLowerCase().toCharArray()) {
                if (r1.indexOf(c) != -1) {
                    if (row >= 2) {
                        inv = true;
                        break;
                    }
                    row = 1;
                }
                else if (r2.indexOf(c) != -1) {
                    if (row == 1 || row == 3) {
                        inv = true;
                        break;
                    }
                    row = 2;
                } 
                else {
                    if (row == 1 || row == 2) {
                        inv = true;
                        break;
                    }
                    row = 3;
                }
            }

            if (!inv) {
                ret.add(s);
            }
        }

        return(ret.toArray(new String[0]));
    }
}
