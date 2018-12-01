$(function () {
  $('.ui_moddal').niceScroll({
  autohidemode: 'false',     // Do not hide scrollbar when mouse out
  cursorborderradius: '0px', // Scroll cursor radius
  background: '#E5E9E7',     // The scrollbar rail color
  cursorwidth: '10px',       // Scroll cursor width
  cursorcolor: '#999999'     // Scroll cursor color
});
});



$(function () { $("#logBtn").click(function () { $(".userEntery").toggleClass("zoomIn"), $(".logOverlay").show() }), $(".logOverlay").click(function () { $(".userEntery").removeClass("zoomIn"), $(this).hide() }), $("#closeLog").click(function () { $(".userEntery").removeClass("zoomIn"), $(".logOverlay").hide() }), $("#datetimepicker4").datepicker(), $(".mapMark").click(function (e) { e.preventDefault(), $(".expand-body-right").toggle() }), $(window).resize(function () { window.matchMedia("(max-width: 991px)").matches && ($(".sideMain").removeClass("collasping"), $(".sideMain").removeClass("collasping")) }), window.matchMedia("(max-width: 991px)").matches && ($(".sideMain").removeClass("collasping"), $(window).resize(function () { $(".sideMain").removeClass("collasping") })), $(".tabContainer1,.customs_scrolling").niceScroll({ cursorcolor: "#80706D" }), $("#tab1default .sortable-list").sortable({ connectWith: "#tab1default .sortable-list" }), $("#tab2default .sortable-list").sortable({ connectWith: "#tab2default .sortable-list", placeholder: "placeholder" }), $("#tab3default .sortable-list").sortable({ connectWith: "#tab2default .sortable-list", placeholder: "placeholder" }), $("#tab4default .sortable-list").sortable({ connectWith: "#tab2default .sortable-list", placeholder: "placeholder" }), $("#tab5default .sortable-list").sortable({ connectWith: "#tab2default .sortable-list", placeholder: "placeholder" }) });

$(function () { $("body.script_edit .line_divs > b").click(function () { $(this).next().slideToggle(), $(this).children("i").toggleClass("fa-plus fa-minus") }) });

$("#datetimepicker4").datepicker(), $(".mapMark").click(function (e) { e.preventDefault(), $(".expand-body-right").toggle() }), $(window).resize(function () { window.matchMedia("(max-width: 991px)").matches && ($(".sideMain").removeClass("collasping"), $(".sideMain").removeClass("collasping")) });
