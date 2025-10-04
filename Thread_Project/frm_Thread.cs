using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace Thread_Project
{
    public partial class frm_Thread : Form
    {
        public frm_Thread()
        {
            InitializeComponent();

            // ⚠️ بشكل افتراضي، ويندوز يمنع التغيير على عناصر الواجهة (UI) من ثريد ثاني
            // هذا السطر يسمح بالتغيير المباشر بدون خطأ، لكن يعتبر ممارسة غير آمنة
            CheckForIllegalCrossThreadCalls = false;
        }

        // 🧵 دالة عد بدون تحديد بداية
        void Count()
        {
            // ❌ لو شغلتها في نفس الثريد (UI Thread) → الواجهة تتجمد
            // ✅ لكن لما نشغلها في ثريد منفصل → العداد يشتغل والواجهة تظل سلسة
            while (Convert.ToInt32(lbl_Count.Text) < int.MaxValue)
                lbl_Count.Text = (Convert.ToInt32(lbl_Count.Text) + 1).ToString();
        }

        // 🧵 دالة لتغيير نص الليبل (تُستخدم مع Invoke)
        void ChangeLblCount(int number)
        {
            lbl_Count.Text = number.ToString();
        }

        // 🧵 دالة عد تبدأ من رقم معين
        void CountFrom(object o)
        {
            lbl_Count.Text = o.ToString();

            while (Convert.ToInt32(lbl_Count.Text) < int.MaxValue)
            {
                int count = Convert.ToInt32(lbl_Count.Text) + 1;

                // ✅ هنا استخدمنا Invoke عشان نغيّر قيمة الليبل بشكل آمن من ثريد ثاني
                ChangeLableDelegate changeLblCountdlgt = ChangeLblCount;
                this.Invoke(changeLblCountdlgt, count);

                // 💤 Sleep يوقف الثريد فترة صغيرة (لتخفيف الضغط على CPU)
                Thread.Sleep(100);
            }
        }

        // 📌 زر تشغيل عداد (بدون اختيار رقم بداية)
        private void btn_StartCount_Click(object sender, EventArgs e)
        {
            // إنشاء ثريد جديد للدالة Count
            ThreadStart ThreadStart = new ThreadStart(Count); //
            ThreadCount = new Thread(ThreadStart);

            // ✅ نخلي الثريد Background → ينتهي تلقائيًا مع إغلاق البرنامج
            ThreadCount.IsBackground = true;

            ThreadCount.Start();

            // 🔹 ThreadStart هو Delegate جاهز في C# يمثل دالة:
            //    - بدون معاملات (parameters)
            //    - بدون قيمة إرجاع (void)
            //
            // ➡️ أي ميثود شكله كذا ممكن يشتغل معه:
            //    void Count() { ... }
            //
            // ✅ هنا أنشأنا كائن من نوع ThreadStart وأشرنا به على الدالة Count:
            //    ThreadStart threadStart = new ThreadStart(Count);
            //
            // يعني: "لما يشتغل الثريد، نفّذ الدالة Count".
            //
            // 🔹 بعد ذلك أنشأنا كائن Thread وربطناه بالـ ThreadStart:
            //    ThreadCount = new Thread(threadStart);
            //
            // النتيجة: صار عندنا ثريد جديد (ThreadCount) مرتبط بالدالة Count.
            //
            // 🔄 ملاحظة: في C# الحديثة نادراً نكتبها بالطريقة الطويلة.
            // ممكن نكتبها مختصرة:
            //
            //    // الطريقة المختصرة:
            //    Thread t = new Thread(Count);
            //
            //    // أو باستخدام Lambda Expression:
            //    Thread t = new Thread(() => Count());

        }

        // 🎯 مثال لعداد بدون ثريد → يوضح الفرق
        private void btn_StartCount_NoThread_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100000; i++)
                lbl_Count.Text = i.ToString();
        }


        // 📌 زر تشغيل عداد يبدأ من رقم يحدده المستخدم
        private void btn_StartCountFrom_Click(object sender, EventArgs e)
        {
            // 🔹 ParameterizedThreadStart هو Delegate يسمح بتمرير بارامتر للثريد
            //    على عكس ThreadStart العادي الذي لا يقبل أي معاملات.
            //
            // 🔹 هنا نربط الثريد بالدالة CountFrom التي تستقبل object كمعامل
            ParameterizedThreadStart paramThreadStart = new ParameterizedThreadStart(CountFrom);

            // 🔹 إنشاء كائن Thread جديد وربطه بالـ ParameterizedThreadStart
            Thread thrdCountFrom = new Thread(paramThreadStart);

            // 🔹 بدء الثريد وتمرير القيمة كـ Parameter
            //    في هذا المثال نأخذ الرقم الذي أدخله المستخدم في TextBox
            //    txt_StartNumber.Text يحتوي على النص، ويحول تلقائيًا إلى object
            thrdCountFrom.Start(txt_StartNumber.Text);

            // 🔹 نحفظ الثريد في قائمة (List) ليمكننا التحكم به لاحقًا
            //    مثل الإيقاف أو الإنهاء
            lstStartFromThrds.Add(thrdCountFrom);
        }

        // 📌 زر قتل البرنامج بالكامل
        private void btn_Kill_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        // 📌 زر إيقاف ثريد العد الأساسي
        private void btn_AbortStartCountThread_Click(object sender, EventArgs e)
        {
            ThreadCount.Abort();
        }

        // 📌 زر إيقاف كل الثريدات اللي بدأت بعدد مخصص
        private void btn_AbortAllStartFromThread_Click(object sender, EventArgs e)
        {
            foreach (Thread thrd in lstStartFromThrds)
                thrd.Abort();
        }

        // 📌 مثال استخدام Lambda بدلاً من دالة منفصلة
        private void btn_Lambda_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                while (Convert.ToInt32(lbl_Count.Text) < int.MaxValue)
                {
                    int x = Convert.ToInt32(lbl_Count.Text) + 1;

                    // ✅ هنا استخدمنا Lambda + Invoke لتحديث الليبل
                    this.Invoke(new ChangeLabelDelegateWithoutPrarameter(() =>
                    {
                        lbl_Count.Text = x.ToString();
                    }));
                }
            }).Start();
        }

      
        // ====== تعريفات المندوبين ======
        delegate void ChangeLableDelegate(int x);
        delegate void ChangeLabelDelegateWithoutPrarameter();

        // ====== المتغيرات ======
        Thread ThreadCount;                        // ثريد واحد للعد الأساسي
        List<Thread> lstStartFromThrds = new List<Thread>(); // مجموعة ثريدات لعدة عدادات
    }
}

/* 
==============================================
✅ مميزات استخدام الثريد في هذا الكود:
- البرنامج ما يتجمد (UI يظل شغال).
- تقدر تشغل أكثر من عداد بنفس الوقت.
- تقدر توقف أو تقتل الثريدات حسب الحاجة.

⚠️ عيوب استخدام الثريدات هنا:
- الكود معقد أكثر (Invoke + Delegates).
- استخدام Thread.Abort خطير (ممكن يوقف الثريد بشكل غير منظم).
- كل ثريد يستهلك جزء من الذاكرة + وقت من CPU.
- كثرة الثريدات ممكن تبطئ النظام بسبب الـ Context Switching.

📌 الخلاصة:
- استخدام ثريد واحد أو عدد قليل ممتاز لتجنب تجميد البرنامج.
- لكن كثرة الثريدات = أداء أقل + صعوبة في التحكم.
- الحلول الحديثة: استخدام ThreadPool أو Tasks أو async/await أفضل وأسهل.
==============================================
*/
