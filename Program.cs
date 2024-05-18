double findMedianSortedArrays(int* nums1, int nums1Size, int* nums2, int nums2Size) {
//    if (nums2Size == 0) return nums1;
//    if (nums1Size == 0) return nums2;
    // I'm kind of proud of this program because I wrote it quickly, without assistance and it worked pretty much strait off.
    // It was validation that I still knew C.
    // Although there was obviously room for improvement.
    int nums3[nums1Size + nums2Size];
    int x = 0;
    int y = 0; // nums1Size limit
    int z = 0; // nums2Size limit
    while (x < (nums1Size + nums2Size))
    {
        while ((y < nums1Size)&&(z < nums2Size))
        {
            if(nums1[y] < nums2[z])
            {
                nums3[x] = nums1[y];
                y++;
            }
            else
            {
                nums3[x] = nums2[z];
                z++;
            }
            x++;
        }
        while (y < nums1Size)
        {
            nums3[x] = nums1[y];
            y++;
            x++;
        }
        while (z < nums2Size)
        {
            nums3[x] = nums2[z];
            z++;
            x++;
        }
    }
//    for (int j = 0; j < nums1Size + nums2Size; j++)
//        printf("current list = %d\n",nums3[j]);
    float middleNumber, returnMedian;
    if((nums1Size+nums2Size) % 2 == 0)
    {
        // find middle 2 values
        middleNumber = ((float) nums1Size + (float) nums2Size) / 2.0;
//            printf("current middle is : %f\n", middleNumber);
        for (int j = middleNumber-1; j <= middleNumber; j++)
        {
//            printf("Median Values to Add = %d\n",nums3[j]);
            returnMedian += (float) nums3[j];
        }
        returnMedian = returnMedian / 2;
    }
    else
    {
        middleNumber = ((float) nums1Size + (float) nums2Size) / 2.0;
        int j = middleNumber;
        returnMedian = (float) nums3[j]; 
    }
    return returnMedian;
}