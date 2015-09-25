
add_executable(gballoc_without_init_unittests gballoc_without_init_unittests.cpp main.c)


target_include_directories(gballoc_without_init_unittests PUBLIC ${TEST_INCLUDES})
target_link_libraries (gballoc_without_init_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
