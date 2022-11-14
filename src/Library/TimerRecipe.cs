using System;

namespace Full_GRASP_And_SOLID
{
    public class TimerRecipe : TimerClient
    {
        private Recipe recipe;

        public TimerRecipe(Recipe recipe)
        {
            this.recipe = recipe;
        }

        public object TimeOutId { get; }
        
        public void TimeOut()
        {
            this.recipe.Finish();
        }
    }
}