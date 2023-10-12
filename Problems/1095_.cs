using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1095. Find in Mountain Array
    //(This problem is an interactive problem.)

    //You may recall that an array arr is a mountain array if and only if:

    //arr.length >= 3
    //There exists some i with 0 < i<arr.length - 1 such that:
    //arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
    //arr[i]> arr[i + 1] > ... > arr[arr.length - 1]
    //Given a mountain array mountainArr, return the minimum index such that mountainArr.get(index) == target.If such an index does not exist, return -1.

    //You cannot access the mountain array directly.You may only access the array using a MountainArray interface:

    //MountainArray.get(k) returns the element of the array at index k (0-indexed).
    //MountainArray.length() returns the length of the array.
    //Submissions making more than 100 calls to MountainArray.get will be judged Wrong Answer.Also, any solutions that attempt to circumvent the judge will result in disqualification.
    internal class _1095_
    {
        public int FindInMountainArray(int target, MountainArray mountainArr)
        {
            int peakIndex = FindPeakIndex(mountainArr);

            // Search in the left side of the peak
            int leftIndex = BinarySearch(mountainArr, target, 0, peakIndex, true);
            if (leftIndex != -1)
                return leftIndex;

            // Search in the right side of the peak
            int rightIndex = BinarySearch(mountainArr, target, peakIndex + 1, mountainArr.Length() - 1, false);
            return rightIndex;
        }

        private int FindPeakIndex(MountainArray mountainArr)
        {
            int left = 0;
            int right = mountainArr.Length() - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (mountainArr.Get(mid) < mountainArr.Get(mid + 1))
                    left = mid + 1;
                else
                    right = mid;
            }

            return left;
        }

        private int BinarySearch(MountainArray mountainArr, int target, int left, int right, bool ascending)
        {
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int midValue = mountainArr.Get(mid);

                if (midValue == target)
                    return mid;

                if (ascending)
                {
                    if (midValue < target)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
                else
                {
                    if (midValue > target)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }
            }

            return -1;
        }
    }
}
