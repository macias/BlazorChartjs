﻿window.setup = (id, config) => {
    document.getElementById("chartcontainer" + id).style.display = 'none';
    document.getElementById("chartcontainer" + id).innerHTML = '&nbsp;';
    document.getElementById("chartcontainer" + id).innerHTML = '<canvas id="' + id + '"></canvas>';
    document.getElementById("chartcontainer" + id).style.display = '';

    var ctx = document.getElementById(id).getContext('2d');
    var chart = new Chart(ctx, eval(config));

    chart.options.onClick = function (event, array) {
        var rtn = -1;

        if (array !== undefined && array.length > 0)
            rtn = array[0].index;

        DotNet.invokeMethodAsync('PSC.Blazor.Components.Chartjs', 'ChartClick', rtn);
    };

    chart.options.onHover = function () {
        DotNet.invokeMethodAsync('PSC.Blazor.Components.Chartjs', 'ChartHover');
    }

    chart.options.plugins.legend.onClick = function (e, legendItem, legend) {
    };

    function getImage() {
        return chart.toDataURL("image/png");
    }
}