enum IssueType{
    Task = 'task',
    SubTask = 'sub-task',
    Bug = 'bug',
    Epic = 'epic',
    Story = 'story'
};

export const appConstants = {
    /**Issue Types with their hardcoded colors */

    
    issueTypeListWithColor:{
        [IssueType.Bug]:{
            name:IssueType.Bug,
            color: '#99333352'
        },
        [IssueType.Epic]:{
            name:IssueType.Epic,
            color: '#33996652'
        },
        [IssueType.Story]:{
            name:IssueType.Story,
            color: '#fff3d4'
        },
        [IssueType.Task]: {
            name: IssueType.Task,
            color: '#99ccff61'
        },
        [IssueType.SubTask]:{
            name:IssueType.SubTask,
            color: '#3d7e9a4d'
        },
        
    }
    
}
console.log(appConstants);