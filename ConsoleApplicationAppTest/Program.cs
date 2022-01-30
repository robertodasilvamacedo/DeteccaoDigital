﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Valid.Biometric.FindFingerprintYoloTinyV4;

namespace ConsoleApplicationAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var yoloWrapper = new FindFingerprintYoloTinyV4("yolov4-tiny-digitais_sid.cfg", "yolov4-tiny-digitais_sid_final.weights", "digital_sid.names");

            List<Task> lstTask = new List<Task>();
            Task task1 = Task.Run(() =>
            {
                byte[] fingerprintFound = yoloWrapper.DetectFingerprint(System.IO.File.ReadAllBytes(@"C:\Temp\Log\digital_8656852_1.bmp"));
                System.IO.File.WriteAllBytes("C:\\temp\\digital1.bmp", fingerprintFound);
            });
            lstTask.Add(task1);
            Task task2 = Task.Run(() =>
            {
                byte[] fingerprintFound = yoloWrapper.DetectFingerprint(System.IO.File.ReadAllBytes(@"C:\Temp\Log\digital_8656852_2.bmp"));
                System.IO.File.WriteAllBytes("C:\\temp\\digital2.bmp", fingerprintFound);
            });
            lstTask.Add(task2);
            Task task3 = Task.Run(() =>
            {
                byte[] fingerprintFound = yoloWrapper.DetectFingerprint(System.IO.File.ReadAllBytes(@"C:\Temp\Log\digital_8656852_3.bmp"));
                System.IO.File.WriteAllBytes("C:\\temp\\digital3.bmp", fingerprintFound);
            });
            lstTask.Add(task3);
            Task task4 = Task.Run(() =>
            {
                byte[] fingerprintFound = yoloWrapper.DetectFingerprint(System.IO.File.ReadAllBytes(@"C:\Temp\Log\digital_8656852_4.bmp"));
                System.IO.File.WriteAllBytes("C:\\temp\\digital4.bmp", fingerprintFound);
            });
            lstTask.Add(task4);
            Task task5 = Task.Run(() =>
            {
                byte[] fingerprintFound = yoloWrapper.DetectFingerprint(System.IO.File.ReadAllBytes(@"C:\Temp\Log\digital_8656852_5.bmp"));
                System.IO.File.WriteAllBytes("C:\\temp\\digital5.bmp", fingerprintFound);
            });
            lstTask.Add(task5);
            Task task6 = Task.Run(() =>
            {
                byte[] fingerprintFound = yoloWrapper.DetectFingerprint(System.IO.File.ReadAllBytes(@"C:\Temp\Log\digital_8656852_6.bmp"));
                System.IO.File.WriteAllBytes("C:\\temp\\digital6.bmp", fingerprintFound);
            });
            lstTask.Add(task6);
            Task task7 = Task.Run(() =>
            {
                byte[] fingerprintFound = yoloWrapper.DetectFingerprint(System.IO.File.ReadAllBytes(@"C:\Temp\Log\digital_8656852_7.bmp"));
                System.IO.File.WriteAllBytes("C:\\temp\\digital7.bmp", fingerprintFound);
            });
            lstTask.Add(task7);
            Task.WaitAll(lstTask.ToArray());
        }
    }
}