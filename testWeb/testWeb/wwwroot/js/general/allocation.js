﻿let app = new Vue({
    el: '#app',
    data: {
        allocations: [],
        matchings: [],
        shownMatching: selectedMatching
    },
    methods: {
        async initialize() {
            let response = await fetch(`${params.basePath}/api/allocation/getFinalAllocations`);

            if (response.ok) {
                let result = await response.json();
                this.allocations = result.allocations;
                this.matchings = result.matchings;
            }
        },
        sortAllocationsHandler(key) {
            if (key === 'group')
            {
                this.allocations = this.allocations.sort(function (a, b) {
                    if (a.groupName < b.groupName) return -1;
                    else if (a.groupName === b.groupName) return 0;
                    else return 1;
                });
            }
            else if (key === 'student') {
                this.allocations = this.allocations.sort(function (a, b) {
                    if (a.studentNameAbbreviation < b.studentNameAbbreviation) return -1;
                    else if (a.studentNameAbbreviation === b.studentNameAbbreviation) return 0;
                    else return 1;
                });
            } else if (key === 'tutor') {
                this.allocations = this.allocations.sort(function (a, b) {
                    if (a.tutorNameAbbreviation < b.tutorNameAbbreviation) return -1;
                    else if (a.tutorNameAbbreviation === b.tutorNameAbbreviation) return 0;
                    else return 1;
                });
            } else if (key === 'project') {
                this.allocations = this.allocations.sort(function (a, b) {
                    if (a.projectName < b.projectName) return -1;
                    else if (a.projectName === b.projectName) return 0;
                    else return 1;
                });
            }
        }
    },
    computed: {
        matchingsToShow() {
            return this.allocations.filter(x => x.matchingID === this.shownMatching)
        }
    },
    async mounted() {
        await this.initialize();
    }
});