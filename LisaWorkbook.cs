using System;
using System.IO;
class Solution {
    
    static void Main(String[] args) {
        string[] token_1 = Console.ReadLine().Split(' ');
        int n = int.Parse(token_1[0]);
        int k = int.Parse(token_1[1]);
        
        string[] token_2 = Console.ReadLine().Split(' ');
        // Problem counts for each chapter
        int[] chapProbCounts = Array.ConvertAll(token_2, int.Parse);
        
        // Page counts of each chapter
        int[] chapPageCounts = ArrayProbCountToPageCount(chapProbCounts, k);
        // starting page numbers of all chapters
        int[] chapPageNumber = ComputeChapterPageNumbers(chapPageCounts, k);
        
        int countSpecials = 0;
        
        for (int chap = 0; chap < n; chap++) {
            int startPage = chapPageNumber[chap];
            int numProbs = chapProbCounts[chap];
            int numPages = chapPageCounts[chap];
            
            for(int page = 0; page < numPages; page++) {
                int curPageNumber = page + startPage;
                int firstProbNumber = page*k + 1;
                int lastProbNumber = Math.Min((page+1)*k, numProbs);
                
                if(curPageNumber >= firstProbNumber 
                    && curPageNumber <= lastProbNumber) countSpecials++;                
            }
        }
        
        Console.WriteLine(countSpecials);        
    }
    
    
    // translates number of problems to number of pages required.
    static int NumProbsToPages(int numProbs, int probsPerPage) {
        int numPages = numProbs/probsPerPage + 
                        ((numProbs%probsPerPage==0) ? 0 : 1);
        return numPages;
    }
    
    // Converts an array of #of problems to array of #of pages required
    static int[] ArrayProbCountToPageCount(int[] probCounts, int k) {
        int[] pageCounts = new int[probCounts.Length];
        for(int i = 0; i < probCounts.Length; i++) {
            pageCounts[i] = NumProbsToPages(probCounts[i], k);
        }
        return pageCounts;
    }
    
    // Computes the starting page numbers of each chapter 
    static int[] ComputeChapterPageNumbers(int[] pageCounts, int k) {
        int[] pageNum = new int[pageCounts.Length];
        pageNum[0]=  1;
        for (int i = 1; i < pageCounts.Length; i++) {
            pageNum[i] = pageNum[i-1] + pageCounts[i-1];
        }
        return pageNum;
    }    
    
    
}
