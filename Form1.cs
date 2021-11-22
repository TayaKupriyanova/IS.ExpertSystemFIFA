using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ExpertSystem
{
    public partial class Form : System.Windows.Forms.Form
    {
        string STYLEGA, STYLEGD;
        string errorChecked = "Ошибка в указании мастерства. Выберите один вариант.";
        string errorStyle = "Ошибка в указании стиля игры. Необходимо выбрать один стиль атаки и один стиль защиты";
        SchemeRule[] schemeRules;
        TacticRule[] tacticRules;
        TasksRule[] tasksRules;
        SquadRule[] squadRules;
        public Form()
        {
            InitializeComponent();
        }

        private void GetRes_Click(object sender, EventArgs e)
        {
            // проверяем правила на наличие ошибок
            CheckData();

            // считываем введенную пользователем информацию в специальный класс
            ActualData actualData = new ActualData((int)Bbudg.Value, CBAt.SelectedItem.ToString(), CBDef.SelectedItem.ToString(), (int)Btime.Value, ChBLower.Checked);
            TBRes.Clear();

            // заполняем базу знаний правилами
            LoadRules();        
            
            // выбираем из всей базы правила, подходящие нам
            ActualRules actualRules = new ActualRules();
            actualRules.getActualRules(schemeRules, tacticRules, tasksRules, squadRules, actualData);

            // берем из него все следствия и копируем в IntermediateGoals
            IntermediateGoals IG = new IntermediateGoals(actualRules);
            
            // выводим его в TBRrs
            TBRes.Text = "Схема игры: " + IG.scheme + Environment.NewLine + Environment.NewLine + "Тактика игры: " + IG.tactic + Environment.NewLine + Environment.NewLine + "Задачи игрокам: " + IG.tasks + Environment.NewLine + Environment.NewLine + " Состав команды: " + IG.squad;



        }

        void CheckData()
        {
            // здесь должна быть проверка введенных результатов
            string error = " ";
            if ((ChBLower.Checked & ChBHigher.Checked) | (!ChBLower.Checked & !ChBHigher.Checked)) error += errorChecked;
            if ((STYLEGA == null) | (STYLEGD == null)) error += errorStyle;

             try
             {
                 if ((ChBLower.Checked & ChBHigher.Checked) | (!ChBLower.Checked & !ChBHigher.Checked)) error += errorChecked;
                 STYLEGA = CBAt.SelectedItem.ToString();
                 STYLEGD = CBDef.SelectedItem.ToString();

             }

             catch (System.NullReferenceException)
             {
                 error += errorStyle;
                System.Windows.Forms.Application.Exit();
            }

        }

        void LoadRules()
        {
            // подключить и привязать эксель
            Microsoft.Office.Interop.Excel.Application DB = new Microsoft.Office.Interop.Excel.Application();

            Workbook exel = DB.Workbooks.Open(@"D:\Common (G)\Учеба)0)(((000\7 семестр (текущий)\Интеллектуальные системы\лабы\лаба1\Database.xlsx");
            _Worksheet schemeSheet = exel.Sheets[1];
            _Worksheet tacticSheet = exel.Sheets[2];
            _Worksheet tasksSheet = exel.Sheets[3];
            _Worksheet squadSheet = exel.Sheets[4];

            Range schemeRange = schemeSheet.UsedRange;
            Range tacticRange = tacticSheet.UsedRange;
            Range tasksRange = tasksSheet.UsedRange;
            Range squadRange = squadSheet.UsedRange;

            // перенести информацию из базы знаний в объекты
            int schemeN = 36;
            schemeRules = new SchemeRule[schemeN];
            string scheme, stylea, styled; int mast, timeH, timeL; 
            for ( int i =0; i< schemeN; i++)
            {
                scheme = schemeRange.Cells[i + 2, 1].Value2.ToString();
                stylea = schemeRange.Cells[i + 2, 5].Value2.ToString();
                styled = schemeRange.Cells[i + 2, 6].Value2.ToString();
                timeH = Convert.ToInt32(schemeRange.Cells[i + 2, 3].Value2.ToString());
                timeL = Convert.ToInt32(schemeRange.Cells[i + 2, 4].Value2.ToString());
                mast = Convert.ToInt32(schemeRange.Cells[i + 2, 2].Value2.ToString());

                schemeRules[i] = new SchemeRule(mast, timeH, timeL, stylea, styled, scheme);
            }
            
            int tacticN = 9;
            tacticRules = new TacticRule[tacticN];
            for (int i = 0; i < tacticN; i++)
            {
                tacticRules[i] = new TacticRule(tacticRange.Cells[i + 2, 2].Value2.ToString(), tacticRange.Cells[i + 2, 3].Value2.ToString(), tacticRange.Cells[i + 2, 1].Value2.ToString());
            }

            int tasksN = 9;
            tasksRules = new TasksRule[tasksN];
            for (int i = 0; i < tasksN; i++)
            {
                tasksRules[i] = new TasksRule(tasksRange.Cells[i + 2, 2].Value2.ToString(), tasksRange.Cells[i + 2, 3].Value2.ToString(), tasksRange.Cells[i + 2, 1].Value2.ToString());
            }

            int squadN = 27;
            squadRules = new SquadRule[squadN];
            int budgH, budgL;
            for (int i = 0; i < squadN; i++)
            {
                budgH = Convert.ToInt32(squadRange.Cells[i + 2, 2].Value2.ToString());
                budgL = Convert.ToInt32(squadRange.Cells[i + 2, 3].Value2.ToString());

                squadRules[i] = new SquadRule(budgH, budgL, squadRange.Cells[i + 2, 4].Value2.ToString(), squadRange.Cells[i + 2, 5].Value2.ToString(), squadRange.Cells[i + 2, 1].Value2.ToString());
            }

            // завершаем работу экселя
            DB.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(DB);

        }

    }

    public class ActualData {
        public int budget;
        public string styleA;
        public string styleD;
        public int timeg;
        public int mast;

        public ActualData(int BUDG, string STYLEA, string STYLED, int TIME, bool LOW)
        {
            budget = BUDG;
            styleA = STYLEA;
            styleD = STYLED;
            timeg = TIME;
            if (LOW) mast = 0;
            else mast = 1;
        }
    }
    public class ActualRules {
        public SchemeRule schemeRule;
        public TacticRule tacticRule;
        public TasksRule tasksRule;
        public SquadRule squadRule;

        public ActualRules()
        {
            schemeRule = null;
            tacticRule = null;
            tasksRule = null;
            squadRule = null;
        }

        public void getActualRules(SchemeRule[] schR, TacticRule[] tacR, TasksRule[] taskR, SquadRule[] squadR, ActualData AD)
        {

            // проходим по массивам объектов с правилами и выбираем подходящие, сравнивания с объектом AD
            for (int i =0; i< schR.Length; i++)
            {
                if (schR[i].isTrue(AD.mast, AD.timeg, AD.styleA, AD.styleD))
                {
                    schemeRule = schR[i];
                    break;
                }
            }

            for (int i =0; i<tacR.Length; i++)
            {
                if(tacR[i].isTrue(AD.styleA, AD.styleD))
                {
                    tacticRule = tacR[i];
                    break;
                }
            }

            for (int i =0; i< taskR.Length; i++)
            {
                if(taskR[i].isTrue(AD.styleA, AD.styleD))
                {
                    tasksRule = taskR[i];
                    break;
                }
            }

            for( int i =0; i< squadR.Length; i++)
            {
                if(squadR[i].isTrue(AD.budget, AD.styleA, AD.styleD))
                {
                    squadRule = squadR[i];
                    break;
                }
            }
        }
    }
    public class IntermediateGoals {
        public string scheme;
        public string tactic;
        public string tasks;
        public string squad;

        public IntermediateGoals(ActualRules actualRules) {
            scheme = actualRules.schemeRule.schemeG;
            tactic = actualRules.tacticRule.tactic;
            tasks = actualRules.tasksRule.tasks;
            squad = actualRules.squadRule.squad;
        }

    }
    public class GOALVAR {
        public string result;

        public GOALVAR(IntermediateGoals IG)
        {
        }

    }
    public class SchemeRule {
        public int mast;
        public int timeH;
        public int timeL;
        public string styleA;
        public string styleD;
        public string schemeG;

        public SchemeRule(int M, int TH, int TL, string SA, string SD, string SC) {
            mast = M;
            timeH = TH;
            timeL = TL;
            styleA = SA;
            styleD = SD;
            schemeG = SC;
        }
        public bool isTrue(int M, int T, string SA, string SD)
        {
            if ((mast == M) & (T <= timeH) &(T>=timeL) & (styleA == SA) & (styleD == SD))
                return true;
            else return false;
        }

    }
    public class TacticRule {
        public string styleA;
        public string styleD;
        public string tactic;

        public TacticRule(string SA, string SD, string T) {
            styleA = SA;
            styleD = SD;
            tactic = T;
        }
        public bool isTrue(string SA, string SD)
        {
            if ((styleA == SA) & (styleD == SD))
                return true;
            else return false;
        }
    }
    public class TasksRule {
        public string styleA;
        public string styleD;
        public string tasks;

        public TasksRule(string SA, string SD, string T) {
            styleA = SA;
            styleD = SD;
            tasks = T;
        }
        public bool isTrue(string SA, string SD)
        {
            if ((styleA == SA) & (styleD == SD))
                return true;
            else return false;
        }
    }
    public class SquadRule {
        public int budgetH;
        public int budgetL;
        public string styleA;
        public string styleD;
        public string squad;

        public SquadRule(int BH, int BL, string SA, string SD, string T) {
            budgetH = BH;
            budgetL = BL;
            styleA = SA;
            styleD = SD;
            squad = T;
        }
        public bool isTrue(int B, string SA, string SD)
        {
            if ((B <= budgetH) & (B >= budgetL) & (styleA == SA) & (styleD == SD))
                return true;
            else return false;
        }
    }

}
