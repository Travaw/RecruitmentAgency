using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using RecruitmentAgency.Core.Entities;

namespace RecruitmentAgency.Api.Helpers
{
    /// <summary>
    /// Генератор поисковых запросов
    /// </summary>
    public class RequestHelper
    {
        /// <summary>
        /// Генерация запроса по вакансиям
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="experience">Опыт работы</param>
        /// <param name="professionalField">Сфера деятельности</param>
        /// <param name="description">Описние</param>
        /// <param name="requirements">Требовни</param>
        /// <param name="salary">З/п</param>
        /// <returns></returns>
        public static Expression<Func<Vacancy, bool>> CreateVacancyLambda(string name, int? experience, string professionalField, string description, string requirements, int? salary)
        {
            var vacancy = Expression.Parameter(typeof(Vacancy), "s");
            List<Expression> equals = new List<Expression>();
            if (name != null && name != "")
            {
                var position = Expression.PropertyOrField(vacancy, "Name");
                var pos = Expression.Constant(name);
                equals.Add(Expression.Equal(position, pos));
            }
            if (experience != null)
            {
                var exp = Expression.PropertyOrField(vacancy, "Experience");
                var e = Expression.Constant(experience);
                equals.Add(Expression.Equal(exp, e));
            }
            if (professionalField != null && professionalField != "")
            {
                var profField = Expression.PropertyOrField(vacancy, "ProfessionalField");
                var pF = Expression.Constant(professionalField);
                equals.Add(Expression.Equal(profField, pF));
            }
            if (description != null && description != "")
            {
                var desc = Expression.PropertyOrField(vacancy, "Description");
                ConstantExpression kW;
                System.Reflection.MethodInfo methodInfo = typeof(string).GetMethod("ToLower", new Type[] { });
                var toLower = Expression.Call(desc, methodInfo);
                MethodCallExpression callExpr;
                List<Expression> contains = new List<Expression>();
                string[] keyWords = description.Trim(new Char[] { ',', '.', '!', '?' }).ToLower().Split(' ');
                foreach (var keyWord in keyWords)
                {
                    kW = Expression.Constant(keyWord);

                    callExpr = Expression.Call(toLower, typeof(string).GetMethod("Contains"), new Expression[] { kW });
                    equals.Add(callExpr);
                }
            }
            if (requirements != null && requirements != "")
            {
                var req = Expression.PropertyOrField(vacancy, "Requierements");
                ConstantExpression kW;
                System.Reflection.MethodInfo methodInfo = typeof(string).GetMethod("ToLower", new Type[] { });
                var toLower = Expression.Call(req, methodInfo);
                MethodCallExpression callExpr;
                List<Expression> contains = new List<Expression>();
                string[] keyWords = requirements.ToLower().Split(' ');
                foreach (var keyWord in keyWords)
                {
                    kW = Expression.Constant(keyWord.Trim(new Char[] { ',', '.', '!', '?' }));

                    callExpr = Expression.Call(toLower, typeof(string).GetMethod("Contains"), new Expression[] { kW });
                    equals.Add(callExpr);
                }
            }

            if (salary != null )
            {
                var s = Expression.Constant(salary);
                var salaryFrom = Expression.PropertyOrField(vacancy, "SalaryFrom");
                var salaryTo = Expression.PropertyOrField(vacancy, "SalaryTo");
                var gr = Expression.GreaterThanOrEqual(s, salaryFrom);
                var less = Expression.LessThanOrEqual(s, salaryTo);
                equals.Add(gr);
                equals.Add(less);
               
                
            }
            int cnt = equals.Count;
            Expression expr;
            switch (cnt)
            {
                case 0:
                    expr = null;
                    break;
                case 1:
                    expr = equals[0];
                    break;
                case 2:
                    expr = Expression.And(equals[0], equals[1]);
                    break;
                default:
                    expr = Expression.And(equals[0], equals[1]);
                    for (int i = 2; i < equals.Count; i++)
                    {
                        expr = Expression.And(expr, equals[i]);
                    }
                    break;
            }
            if (expr != null)
            {
                var lambda = Expression.Lambda<Func<Vacancy, bool>>(expr, new ParameterExpression[] { vacancy });
                return lambda;
            }
            else { return null; }

        }

        /// <summary>
        /// Генерация запроса по кандидатам
        /// </summary>
        /// <param name="experience">Опыт работы</param>
        /// <param name="professionalField">Сфера деятельности</param>
        /// <param name="skills">Навыки</param>
        /// <returns></returns>
        public static Expression<Func<Candidate, bool>> CreateCandidateLambda(int? experience, string professionalField, string skills)
        {
            var candidate = Expression.Parameter(typeof(Candidate), "s");
            List<Expression> equals = new List<Expression>();
            if (experience != null)
            {
                var exp = Expression.PropertyOrField(candidate, "Experience");
                var e = Expression.Constant(experience);
                equals.Add(Expression.Equal(exp, e));
            }
            if (professionalField != null && professionalField != "")
            {
                var profField = Expression.PropertyOrField(candidate, "ProfessionalField");
                var pF = Expression.Constant(professionalField);
                equals.Add(Expression.Equal(profField, pF));
            }
           
            if (skills != null && skills != "")
            {
                var req = Expression.PropertyOrField(candidate, "Skills");
                ConstantExpression kW;
                System.Reflection.MethodInfo methodInfo = typeof(string).GetMethod("ToLower", new Type[] { });
                var toLower = Expression.Call(req, methodInfo);
                MethodCallExpression callExpr;
                List<Expression> contains = new List<Expression>();
                string[] keyWords = skills.ToLower().Split(' ');
                foreach (var keyWord in keyWords)
                {
                    kW = Expression.Constant(keyWord.Trim(new Char[] { ',', '.', '!', '?' }));

                    callExpr = Expression.Call(toLower, typeof(string).GetMethod("Contains"), new Expression[] { kW });
                    equals.Add(callExpr);
                }
            }
            
            int cnt = equals.Count;
            Expression expr;
            switch (cnt)
            {
                case 0:
                    expr = null;
                    break;
                case 1:
                    expr = equals[0];
                    break;
                case 2:
                    expr = Expression.And(equals[0], equals[1]);
                    break;
                default:
                    expr = Expression.And(equals[0], equals[1]);
                    for (int i = 2; i < equals.Count; i++)
                    {
                        expr = Expression.And(expr, equals[i]);
                    }
                    break;
            }
            if (expr != null)
            {
                var lambda = Expression.Lambda<Func<Candidate, bool>>(expr, new ParameterExpression[] { candidate });
                return lambda;
            }
            else { return null; }

        }
    }
}
