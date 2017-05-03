
using TechTalk.SpecFlow;

namespace SearchRankings.Specs.StepDefinitions
{
    public class BaseSteps : Steps
    {

        /// <summary>
        /// Retrieves the first object found of the specified type - T - in the scenario context.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Get<T>()
        {
            return ScenarioContext.Get<T>();
        }

        /// <summary>
        /// Stores an object in the scenario context based on type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        public void Set<T>(T obj)
        {
            ScenarioContext.Set<T>(obj);
        }
    }
}
